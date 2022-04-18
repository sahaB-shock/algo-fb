using System;

namespace AlgoFB.DataStructure
{
    public class Min_Heap
    {
        //Ref:https://www.youtube.com/watch?v=t0Cq6tVNRBA
        //https://www.youtube.com/watch?v=HqPJF2L5h9U

        private double[] _storage;
        private int _current_size = 0;
        private int _capacity;

        public Min_Heap(int capacity)
        {
            _storage = new double[capacity];
            _capacity = capacity;
        }

        #region Get Index Left Child Right Child & Parent : Main

        private int Get_Left_Child_Index(int parent_index)
        {
            return (2 * parent_index) + 1;//WOW
        }

        private int Get_Right_Child_Index(int parent_index)
        {
            return (2 * parent_index) + 2;//WOW
        }

        private int Get_Parent_Index(int child_index)
        {
            return (child_index - 1) / 2;//WOW
        }

        #endregion Get Index Left Child Right Child & Parent : Main

        #region Has Left/Right Child | Parent

        private bool Has_Left_Child(int index)
        {
            return Get_Left_Child_Index(index) < _current_size;
        }

        private bool Has_Right_Child(int index)
        {
            return Get_Left_Child_Index(index) < _current_size;
        }

        private bool Has_Parent(int index)
        {
            return Get_Parent_Index(index) >= 0;//WOW
        }

        #endregion Has Left/Right Child | Parent

        #region Get Left/Right Child | Parent Value
        private double Get_Left_Child_Value(int index)
        {
            return _storage[Get_Left_Child_Index(index)];
        }

        private double Get_Right_Child_Value(int index)
        {
            return _storage[Get_Right_Child_Index(index)];
        }

        private double Get_Parent_Value(int index)
        {
            return _storage[Get_Parent_Index(index)];
        }
        #endregion

        #region Read Root Value Peek
        public double Get_Value_Peek()
        {
            if (_current_size == 0)//heap is empty
                throw new Exception("Heap is empty");

            return _storage[0];//Always get data from heap root. //for min heap it should be lowest value.
        } 
        #endregion

        #region Add Value | Bubble Up for Min Value
        public void Add_Value_Push(double data)
        {
            Check_Storage_Size_Or_Increase();//Check or increase storae
            _storage[_current_size] = data;//Place the new value at end.
            _current_size++;//increase the heap size count
            Heapify_To_Up_To_Move_Lowest_In_Up_While_Adding();//
        }
        private void Heapify_To_Up_To_Move_Lowest_In_Up_While_Adding()
        {
            var last_value_index = _current_size - 1;
            while (Has_Parent(last_value_index)
                  && Get_Parent_Value(last_value_index) > _storage[last_value_index])//WOW//
            {
                Swap(Get_Parent_Index(last_value_index), last_value_index);
                last_value_index = Get_Parent_Index(last_value_index);
            }
        }
        #endregion

        #region Delete Root Value and traverse down to find min to make it root
        public double Delete_Pop_Poll_Node()
        {
            if (_current_size == 0)//heap is empty
                throw new Exception("Heap is empty");

            var val = _storage[0];
            _storage[0] = _storage[_current_size - 1];//Bring the last element in top.
                                                      //then hepify down if it's higher value than
            Heapify_To_Down_To_Move_Higher_In_Down_While_Deleting();

            return val;
        }

        private void Heapify_To_Down_To_Move_Higher_In_Down_While_Deleting()
        {
            //In delete we already moved last element (size - 1) in 0 index (root).
            //Now move it down to left
            var root_val_index = 0;
            while (Has_Left_Child(root_val_index))
            {
                //find the small value index from Left & Right both
                var smaller_child_index = Get_Left_Child_Index(root_val_index);
                if (Has_Right_Child(root_val_index) && Get_Right_Child_Value(root_val_index) < Get_Left_Child_Value(root_val_index))
                {
                    smaller_child_index = Get_Right_Child_Index(root_val_index);
                }

                if (_storage[root_val_index] > _storage[smaller_child_index])
                {
                    Swap(root_val_index, Get_Left_Child_Index(root_val_index));
                    root_val_index = Get_Left_Child_Index(root_val_index);
                }
                else
                {
                    break;
                }
            }
        }
        #endregion

        #region Swap
        private void Swap(int i, int j)
        {
            var tmp = _storage[i];
            _storage[i] = _storage[j];
            _storage[j] = tmp;
        }
        #endregion

        #region Get Size
        public int Get_Size()
        {
            return _current_size;
        } 
        #endregion

        #region Resize Array
        private void Check_Storage_Size_Or_Increase()
        {
            if (_current_size == _capacity)
            {
                Array.Resize(ref _storage, _capacity * 2);
            }
        }
        #endregion

        /*
         PriorityQueue<Long> queue = new PriorityQueue<Long>();//WOW
		while(t-- > 0){
			String str[]  = reader.readLine().trim().split(" ");
			if(str[0].equals("1")){
				queue.add(Long.parseLong(str[1]));
			}else if(str[0].equals("2")){
				queue.remove(Long.parseLong(str[1]));
			}else{
				System.out.println(queue.peek());
			}
		}
         */
    }
}