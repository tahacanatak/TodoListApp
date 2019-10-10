using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoListApp
{
     
    public partial class Form1 : Form
    {
        TodoListDbEntities db = new TodoListDbEntities();
        public Form1()
        {
            InitializeComponent();
            ListToDos();
        }

        private void ListToDos()
        {
            clbToDos.Items.Clear();
            clbToDos.DisplayMember = "Title";

            foreach (TodoItem item in db.TodoItems.OrderByDescending( x => x.Id)) // id  ye göre sıralar
            {
                clbToDos.Items.Add(item, item.IsDone); // IsDone Seciliyse secili gelsin
            }
        }

        private void txtToDo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string title = txtToDo.Text.Trim();

                if (title == "")
                    return;

                TodoItem item = new TodoItem { Title = title };
                db.TodoItems.Add(item);
                db.SaveChanges(); //değişiklikleri kaydet

                //MessageBox.Show(item.Id.ToString());

                clbToDos.Items.Insert(0, item); // en başa ekler

                e.SuppressKeyPress = true;
                txtToDo.Clear();
            }
        }

        private void clbToDos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && clbToDos.SelectedIndex > -1)
            {
                TodoItem item = (TodoItem)clbToDos.SelectedItem;

                db.TodoItems.Remove(item);
                db.SaveChanges();

                clbToDos.Items.Remove(item);
            }
        }

        private void clbToDos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            TodoItem item = (TodoItem)clbToDos.Items[e.Index];
            item.IsDone = e.NewValue == CheckState.Checked ? true : false;
            db.SaveChanges(); 
        }
    }
}
