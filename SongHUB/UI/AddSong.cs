using SongHUB.Domain;
using SongHUB.Data;

namespace SongHUB
{
    public partial class AddSong : Form
    {
        private readonly ISongRepository _songRepository;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
       string.IsNullOrWhiteSpace(txtSinger.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            Song song = new Song
            {
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

        private void ClearInputs()
        {
            txtTitle.Clear();
            txtSinger.Clear();
            txtLyrics.Clear();
            cmbType.SelectedIndex = -1;
        }

        private void dgvSongList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvSongList.Rows[e.RowIndex];

            txtTitle.Text = row.Cells["Title"].Value.ToString();
            txtSinger.Text = row.Cells["Singer"].Value.ToString();
            cmbType.Text = row.Cells["SongType"].Value.ToString();
            txtLyrics.Text = row.Cells["Lyrics"].Value.ToString();
        }

        private void LoadSongs()
        {
            dgvSongList.DataSource = null;
            dgvSongList.DataSource = _songRepository.GetAllSongs();
        }

    }
}
