using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private UsersDbContext dbContext = new UsersDbContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.Users.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Username = username.Text,
                Guid = Guid.NewGuid(),
                Age = int.Parse(userAge.Text),
                RegistrDate = userRegistrDate.Value
            };
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            dataGridView1.DataSource = dbContext.Users.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            User user = (User)row.DataBoundItem;
            User user1 = dbContext.Users.FirstOrDefault(u => u.Guid == user.Guid);
            dbContext.Users.Remove(user1);
            dbContext.SaveChanges();
            dataGridView1.DataSource = dbContext.Users.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            User user = (User)row.DataBoundItem;
            User user1 = dbContext.Users.FirstOrDefault(u => u.Guid == user.Guid);
            user1.Username = username.Text;
            user1.Age = int.Parse(userAge.Text);
            user1.RegistrDate = userRegistrDate.Value;
            dbContext.SaveChanges();
            dataGridView1.DataSource = dbContext.Users.ToList();
        }

        private void SearchByName_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            List<User> list = dbContext.Users.ToList();
            list = list.FindAll(u => u.Username.ToString().Contains(name));
            dataGridView1.DataSource = list;
        }

        private void SearchByAge_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            List<User> list = dbContext.Users.ToList();
            list = list.FindAll(u => u.Age.ToString().Contains(name));
            dataGridView1.DataSource = list;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.Users.ToList();
        }
    }
}