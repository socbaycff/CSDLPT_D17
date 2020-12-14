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
        void redo();
        void commit();
    }


    class CommandManager {
    
        private Stack<Action> undoStack;
        private Stack<Action> redoStack;
        public CommandManager() {
            undoStack = new Stack<Action>();
            redoStack = new Stack<Action>();
            
        }

        public Action getLastUndoNode() {
            return undoStack.Peek();
        }

        public int undoStackSize() {
            return undoStack.Count;
        }

        public int redoStackSize()
        {
            return redoStack.Count;
        }

        public void execute(Action action){ // dung cho action 1 giai doan (delete)
            action.execute();
            undoStack.Push(action);
            redoStack.Clear(); // xoa redo khi user thao tac
        }

        // prepare commit danh 2 loai action su dung 2 giai doan (insert,update)
        public void prepare(Action action)
        {
            action.execute();
            undoStack.Push(action);
        }

        public void commit(){ 
            undoStack.Peek().commit();
            redoStack.Clear();// xoa redo khi user thao tac
        }

        public void undo() {
            Action action = undoStack.Pop();
            action.undo();
            redoStack.Push(action);
        }

        public void redo() {
            Action action = redoStack.Pop();
            action.redo();
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
        Object prime; // khoa chinh
        Object[] data;
        String primeName;

        public DeleteAction(BindingSource binding, String primaryName) {
            this.binding = binding;
            this.primeName = primaryName;
        }

        public void execute()
        {
            // save lai data
            data =  ((DataRowView)binding.Current).Row.ItemArray;
            prime = data[0];
            // thuc thi delete tai vi tri user chon
           binding.RemoveCurrent(); // delete dong hien tai (user chi dinh)
        }

        public void redo()
        {
            // thuc thi delete tai khoa chinh
            int pos = binding.Find(primeName, prime);
            binding.RemoveAt(pos); // delete lai dong do
        }

        public void undo()
        {
            // insert lai data o vi tri cuoi (do k biet insert lai dung vi tri)
            binding.AddNew();
            DataRowView row = (DataRowView)binding.Current;
            for (int i = 0; i < data.Length; i++)
            {
                row[i] = data[i];
            }
         
            binding.EndEdit();
            binding.ResetCurrentItem();      
            binding.MoveLast(); // di den vi tri vua insert lai
           
        }
        public void commit() { }
    }

    // edit lai class se chay sau khi user nhap data, de co dc data redo
    class InsertAction : Action
    {
        public BindingSource binding;
        Object[] data;
        Object prime;
        String primeName;
        public InsertAction(BindingSource binding, String primaryName)
        {
            this.binding = binding;
            primeName = primaryName;
        }

        // chay insert voi data user nhap, chay sau getdata()
        public void execute()
        {
            binding.AddNew(); // tao dong trong va nhay xuong cho edit
        }

        // chay khi user bam nut chuan bi insert
         public void redo() {
            binding.AddNew(); // tao dong trong va nhay xuong cho edit
            // update lai data
            DataRowView row = (DataRowView)binding[binding.Position];
            for (int i = 0; i < data.Length; i++)
            {
                row[i] = data[i];
            }
            binding.EndEdit();
            binding.ResetCurrentItem();
            binding.MoveLast(); // di den vi tri insert lai
        }
        // can goi de luu data cho redo
        public void commit() {
            data = ((DataRowView)binding.Current).Row.ItemArray;
            prime = data[0];
        }

        public void undo()
        {
            // delete record dc insert tai vi tri da save
            int pos = binding.Find(primeName, prime);
            binding.RemoveAt(pos);
        }
    }



    // tuong tu insert action: luu data truoc de undo, data sau de redo
    class UpdateAction : Action
    {
        BindingSource binding;
        Object prime;
        String primeName;
        Object[] oldData;
        Object[] newData;
        public UpdateAction(BindingSource binding, String primaryName) {
            this.binding = binding;
            primeName = primaryName;
        }
        
        public void execute()
        {
            // save lai data
            oldData = ((DataRowView)binding.Current).Row.ItemArray;
            prime = oldData[0]; // do khoa chinh khong dc thay doi khi update -> su dung luon old data
            
        }
        // khoi tao bat dau nhap lieu, giai doan 1
        public void redo() {
            // update lai data
            int pos = binding.Find(primeName, prime);
            DataRowView row = (DataRowView)binding[pos];
            for (int i = 0; i < oldData.Length; i++)
            {
                row[i] = newData[i];
            }
            binding.EndEdit();
            binding.ResetCurrentItem();
            binding.Position = pos; // di chuyen den vi tri dong dc redo       
        }

        // can goi de luu data cho redo
        public void commit()
        {
            binding.EndEdit();
            binding.ResetCurrentItem(); 
            newData = ((DataRowView)binding.Current).Row.ItemArray; 
        }

        public void undo()
        {
            int pos = binding.Find(primeName, prime);
            // update lai data
            DataRowView row = (DataRowView)binding[pos];
            for (int i = 0; i < oldData.Length; i++)
            {
                row[i] = oldData[i];
            }
            binding.EndEdit();
            binding.ResetCurrentItem();
            binding.Position = pos;
        }
    }
}
