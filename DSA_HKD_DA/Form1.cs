using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA_new
{
    public partial class Form1 : Form
    {
        // Định nghĩa Node cho LinkedList
        class PostNode
        {
            public int ID;
            public string UserName;
            public string Content;
            public PostNode Next;

            public PostNode(int id, string user, string content)
            {
                ID = id;
                UserName = user;
                Content = content;
                Next = null;
            }
        }

        private PostNode head = null; // Điểm bắt đầu của danh sách liên kết
        private int nextID = 1; // ID tự động tăng

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnDang_Click(object sender, EventArgs e)
        {
            string userName = txtTenNguoiDang.Text;
            string content = txtNoiDung.Text;

            if (!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(content))
            {
                PostNode newPost = new PostNode(nextID, userName, content);
                nextID++;

                if (head == null)
                    head = newPost;
                else
                {
                    PostNode temp = head;
                    while (temp.Next != null)
                        temp = temp.Next;
                    temp.Next = newPost;
                }

                DisplayPosts();
                txtTenNguoiDang.Clear();
                txtNoiDung.Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhapID.Text, out int id))
            {
                if (head == null) return;

                if (head.ID == id)
                    head = head.Next;
                else
                {
                    PostNode temp = head;
                    while (temp.Next != null && temp.Next.ID != id)
                        temp = temp.Next;
                    if (temp.Next != null)
                        temp.Next = temp.Next.Next;
                }

                DisplayPosts();
                txtNhapID.Clear();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = txtNhapID.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText)) return;

            listBoxNoiDung.Items.Clear();
            PostNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (int.TryParse(searchText, out int searchID) && temp.ID == searchID)
                {
                    listBoxNoiDung.Items.Add($"ID: {temp.ID} | {temp.UserName}: {temp.Content}");
                    found = true;
                    break;
                }
                else if (temp.UserName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    listBoxNoiDung.Items.Add($"ID: {temp.ID} | {temp.UserName}: {temp.Content}");
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                listBoxNoiDung.Items.Add("❌ Không tìm thấy bài viết!");
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNhapID.Text, out int postId))
            {
                MessageBox.Show("⚠️ ID phải là một số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newUserName = txtTenNguoiDang.Text.Trim();
            string newContent = txtNoiDung.Text.Trim();

            if (string.IsNullOrWhiteSpace(newUserName) || string.IsNullOrWhiteSpace(newContent))
            {
                MessageBox.Show("⚠️ Vui lòng nhập đầy đủ tên người đăng và nội dung!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PostNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.ID == postId)
                {
                    temp.UserName = newUserName;
                    temp.Content = newContent;
                    found = true;
                    break;
                }
                temp = temp.Next;
            }

            if (found)
            {
                MessageBox.Show("✅ Bài đăng đã được cập nhật!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayPosts();
                txtNhapID.Clear();
                txtTenNguoiDang.Clear();
                txtNoiDung.Clear();
            }
            else
            {
                MessageBox.Show("❌ Không tìm thấy bài đăng có ID này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayPosts()
        {
            listBoxNoiDung.Items.Clear();
            PostNode temp = head;
            while (temp != null)
            {
                listBoxNoiDung.Items.Add($"ID: {temp.ID} | {temp.UserName}: {temp.Content}");
                temp = temp.Next;
            }
        }

        // Các sự kiện giao diện không cần xử lý
        private void lblID_Click(object sender, EventArgs e) { }
        private void lblNoiDung_Click(object sender, EventArgs e) { }
        private void lblNhapten_Click(object sender, EventArgs e) { }
        private void listBoxNoiDung_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtTenNguoiDang_TextChanged(object sender, EventArgs e) { }
        private void txtNoiDung_TextChanged(object sender, EventArgs e) { }
        private void txtNhapID_TextChanged(object sender, EventArgs e)
        { 
            // Không cần Console.ReadLine(), chỉ lấy ID từ TextBox
            if (!string.IsNullOrWhiteSpace(txtNhapID.Text) && !int.TryParse(txtNhapID.Text, out _))
            {
                MessageBox.Show(" ID phải là một số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapID.Clear(); // Xóa nội dung nhập sai
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e) 
        {
            DisplayPosts(); // Gọi lại hàm hiển thị danh sách đầy đủ
            txtNhapID.Clear();
        }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void picBoxAnh_Click(object sender, EventArgs e) { }
        private void lblBaiVietGanDay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã nhấn vào Bài viết gần đây!");
        }
    }
}
