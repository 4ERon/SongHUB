using SongHUB.Domain;
using SongHUB.Data;

namespace SongHUB
{
    public partial class AddSong : Form

    {
        private readonly ISongRepository _songRepository;
        private int _selectedSongId = 0;


        public AddSong()
        {
            InitializeComponent();
            string conn = @"Server=4ERON;
                Database=SongHubDB;
                User Id=sa;
                Password=ronel@123;
                TrustServerCertificate=True;";
            _songRepository = new SongRepository(conn);

            LoadSongs();
        }

        private void ClearInputs()
        {
            txtTitle.Clear();
            txtSinger.Clear();
            txtLyrics.Clear();
            txtSearch.Clear();
            cmbType.SelectedIndex = -1;
            _selectedSongId = 0;
        }

        private void dgvSongList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Assuming you're using a DataGridView
            if (dgvSongList.SelectedRows.Count > 0)
            {
                _selectedSongId = Convert.ToInt32(dgvSongList.SelectedRows[0].Cells["Id"].Value);

                // Load song details into form fields
                var song = _songRepository.GetSongById(_selectedSongId);
                if (song != null)
                {
                    txtTitle.Text = song.Title;
                    txtSinger.Text = song.Singer;
                    cmbType.Text = song.SongType;
                    txtLyrics.Text = song.Lyrics;
                }
            }
        }

        private void LoadSongs()
        {
            dgvSongList.DataSource = null;
            dgvSongList.DataSource = _songRepository.GetAllSongs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            // Check if a song is selected
            if (_selectedSongId == 0)
            {
                MessageBox.Show("Please select a song to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion
            var result = MessageBox.Show(
                "Are you sure you want to delete this song?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (_songRepository.DeleteSong(_selectedSongId))
                {
                    MessageBox.Show("Song deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                    _selectedSongId = 0;  // Reset selected ID
                    LoadSongs();
                }
                else
                {
                    MessageBox.Show("Failed to delete song.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
       string.IsNullOrWhiteSpace(txtSinger.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            Song song = new Song
            {
                Id = _selectedSongId,
                Title = txtTitle.Text.Trim(),
                Singer = txtSinger.Text.Trim(),
                SongType = cmbType.Text,
                Lyrics = txtLyrics.Text
            };

            _songRepository.SaveSong(song);

            MessageBox.Show("Song added successfully!");

            ClearInputs();
            LoadSongs();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadSongs();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string text = txtSearch.Text.Trim();
            var songs = _songRepository.SearchSong(text);
            dgvSongList.DataSource = songs;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
