namespace tentamen
{
    /// Name: Max Appeldorn
    /// StudentNr: 5049350
    /// Date: 20-06-2022
    public partial class Trail : Form
    {

        List<Hotel> hotelList;

        public Trail()
        {
            InitializeComponent();

            hotelList = new List<Hotel>();

        }

        private void importHotels_Click(object sender, EventArgs e)
        {
            StreamReader dataImport = new StreamReader(@"..\..\..\hotels.csv");

            int counter = 0;

            while (!dataImport.EndOfStream)
            {
                string temp = dataImport.ReadLine();
                String[] tempArr = temp.Split(';');
                if (counter > 0)
                {

                    Hotel hotel = new Hotel(tempArr[0]);

                    if (tempArr[1] != "")
                    {
                        Room roomBasic = new Room("Basic", double.Parse(tempArr[1]));
                        hotel.addRoom(roomBasic);
                    }

                    if (tempArr[2] != "")
                    {
                        Room roomStandard = new Room("Standard", double.Parse(tempArr[2]));
                        hotel.addRoom(roomStandard);

                    }

                    if (tempArr[3] != "")
                    {
                        Room roomDeluxe = new Room("Deluxe", double.Parse(tempArr[3]));
                        hotel.addRoom(roomDeluxe);
                    }


                    hotelList.Add(hotel);
                    hotels.Items.Add($"{tempArr[0]},{tempArr[1]},{tempArr[2]},{tempArr[3]}");
                }

                counter++;
            }
        }

        private void calculateCost_Click(object sender, EventArgs e)
        {
            string room = "";
            string overviewStr = "Booked hotels \n ------- \n Hotel - Price \n";
            if (basic.Checked)
            {
                room = basic.Text;
            }else if (standard.Checked)
            {
                room = standard.Text;
            }else if (deluxe.Checked)
            {
                room = deluxe.Text;
            }
            else
            {
                MessageBox.Show("Please select a room");
                return;
            }

            //Checks if selected hotels are between 5 and 10
            if (hotels.SelectedItems.Count < 5 || hotels.SelectedItems.Count > 10)
            {
                MessageBox.Show("Cant have less then 5 hotels selected or more than 10");
                return;
            }

            List<Hotel> selectedHotels = new List<Hotel>();
            double totalPrice = 0.0;

            foreach (string selectedHotel in hotels.SelectedItems)
            {

                String[] tempArr = selectedHotel.Split(',');
                foreach (Hotel hotel in hotelList)
                {
                    if (hotel.name == tempArr[0])
                    {
                        overviewStr += hotel.name + "    " + hotel.getRoomPriceByType(room) + '\n';
                        selectedHotels.Add(hotel);
                        totalPrice += hotel.getRoomPriceByType(room);
                    }
                }

            }

            overviewStr += "Total cost: " + totalPrice + '\n';
            overviewStr += "Avg. per hotel: " + (totalPrice / hotels.SelectedItems.Count).ToString() + '\n';

            showOverview(overviewStr);

            //reset checkboxes
            basic.Checked = false;
            standard.Checked = false;
            deluxe.Checked = false;

        }


        public void showOverview(string content)
        {
            overview.Text = content; 

        }
    }
}