using QLVT_DATHANGD17.QLVT_DATHANGDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLVT_DATHANGD17.QLVT_DATHANGDataSet;

namespace QLVT_DATHANGD17
{
    interface Action
    {
        void execute();
        void undo();
    }


    class CommandManager {
           private static CommandManager instance = null;
        private Stack<Action> undoStack;
        private Stack<Action> redoStack;
        private CommandManager() {
            undoStack = new Stack<Action>();
            redoStack = new Stack<Action>();
        }

        public static CommandManager getInstance() {
            if (instance != null) {
                return instance;
            }
            instance = new CommandManager();
            return instance;
        }

        public int undoStackSize() {
            return undoStack.Count;
        }

        public void execute(Action action)
        {
            action.execute();
            undoStack.Push(action);

        }

        public void undo() {
            
                Action action = undoStack.Pop();
                action.undo();
                redoStack.Push(action);
          
        }

        public void redo() {
            Action action = redoStack.Pop();
            action.execute();
            undoStack.Push(action);
        }
        public void clear() {
            undoStack.Clear();
            redoStack.Clear();
        }


        // khi user chon update/insert nhung cancel ma k commit
        public void clearLastNode() {
            undoStack.Pop();

        }
    }



    class DeleteAction : Action
    {
        BindingSource binding;
  
        Object[] data;

        public DeleteAction(BindingSource binding) {
            this.binding = binding;
           
        }

        public void execute()
        {
            // save lai data
             data =  ((DataRowView)binding.Current).Row.ItemArray;
            // thuc thi delet
           binding.RemoveCurrent();
            
        }

        public void undo()
        {
            // insert lai data
            binding.AddNew();
            DataRowView row = (DataRowView)binding.Current;
            for (int i = 0; i < data.Length; i++) {
                row[i] = data[i];
            }
            binding.EndEdit();
            binding.ResetCurrentItem();
        }
    }


    class InsertAction : Action
    {
        BindingSource binding;
        int position;

        public InsertAction(BindingSource binding)
        {
            this.binding = binding;

        }

        public void execute()
        {
          
            binding.AddNew();
            // save lai vi tri
            position = binding.Position;

        }

        public void undo()
        {
            // delete record dc insert tai vi tri da save
            binding.RemoveAt(position);
        }
    }


    class UpdateAction : Action
    {
        BindingSource binding;
        Object[] data;
        int position;
        public UpdateAction(BindingSource binding) {
            this.binding = binding;
        }
        public void execute()
        {
            // save lai data
            data = ((DataRowView)binding.Current).Row.ItemArray;
            position = binding.Position;
            
        }

        public void undo()
        {
            // update lai data
            DataRowView row = (DataRowView)binding[position];
            for (int i = 0; i < data.Length; i++)
            {
                row[i] = data[i];
            }
            binding.EndEdit();
            binding.ResetCurrentItem();
        }
    }
}
