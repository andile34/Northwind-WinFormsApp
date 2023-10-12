using System.Data.Entity;

namespace NorthwindFormsApp.Helpers
{
    public class SharedFormLogic
    {
        private DbContext _dbContext { get; set; }

        public SharedFormLogic(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void LoadForm<T>(Panel panelContent)
            where T : Form
        {
            panelContent.Controls.Clear();

            // Create an instance of the specified form type
            var form = (T)Activator.CreateInstance(typeof(T), _dbContext);
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelContent.Controls.Add(form);

            form.Show();
        }
    }

    public interface ISharedFormLogic
    {
        void LoadForm<T>(Panel panelContent)
            where T : Form;
    }
}