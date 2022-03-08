using to_do_list.Models;
using Task = to_do_list.Models.Task;

namespace to_do_list
{
    public partial class TaskEntryFrame : Form
    {
        public TaskEntryFrame()
        {
            InitializeComponent();
        }
        ApplicationDbContext _dbContext = new ApplicationDbContext();
        private void button1_Click(object sender, EventArgs e)
        {

                Task task = new Task();
                task.Label = LabelInput.Text;
                task.Comment = CommentInput.Text;
                task.isActive = true;
                _dbContext.Add(task);
                if(_dbContext.SaveChanges()>0)
                {
                    MessageBox.Show("La tâche a bien été créee.","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La tâche n'a pas pu être créee.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            
         /*   catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void CommentInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}