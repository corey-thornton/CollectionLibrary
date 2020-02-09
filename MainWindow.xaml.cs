using Library.controllers;
using Library.model;
using System;
using System.Windows;

namespace Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller controller;

        public MainWindow()
        {
            InitializeComponent();

            this.controller = new Controller();
            this.gameGrid.ItemsSource = this.controller.getGames();
        }



        private void addGameButton_Click(object sender, RoutedEventArgs e)
        {
            var numPlayers = Int32.Parse(this.playerBox.Text);
            var gameToAdd = new Game(this.titleBox.Text,
                                      this.systemBox.Text,
                                      this.devBox.Text,
                                      this.gameTypeBox.Text,
                                      numPlayers);
            this.controller.addNewGame(gameToAdd);
            this.gameGrid.Items.Refresh();

        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            this.controller.saveToFile();
        }
    }
}
