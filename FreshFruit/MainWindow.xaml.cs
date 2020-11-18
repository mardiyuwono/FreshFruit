﻿using FreshFruit.Controller;
using FreshFruit.Model;
using System.Windows;

namespace FreshFruit
{

    public partial class MainWindow : Window, BucketEventListener
    {
        private Seller Mardi;
        Fruit anggur = new Fruit("Anggur");
        Fruit apel = new Fruit("Apel");
        Fruit pisang = new Fruit("Pisang");
        Fruit jeruk = new Fruit("Jeruk");

        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(4);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            Mardi = new Seller("Mardi", bucketController);

            ListBoxBucket.ItemsSource = keranjangBuah.findAll();

        }

        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Mardi.addFruit(anggur);
        }

        private void OnButtonAddApelClicked(object sender, RoutedEventArgs e)
        {
            Mardi.addFruit(apel);
        }

        private void OnButtonAddPisangClicked(object sender, RoutedEventArgs e)
        {
            Mardi.addFruit(pisang);
        }

        private void OnButtonAddJerukClicked(object sender, RoutedEventArgs e)
        {
            Mardi.addFruit(jeruk);
        }
        private void OnButtonClearClicked(object sender, RoutedEventArgs e)
        {
            Mardi.removeFruit(anggur);
            Mardi.removeFruit(apel);
            Mardi.removeFruit(pisang);
            Mardi.removeFruit(jeruk);
        }
        public void onSucceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning !");
        }

        
    }
}
