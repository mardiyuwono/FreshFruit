
# Fruits Shop
(Introduction) Aplikasi ini merupakan sebuah program yang menerapkan konsep MVC, yang di dalamnya terdapat keranjang buah sederhana yang memiliki fitur menambah dan menghapus.

## Scope of functionalities

-   User bisa menekan tombol `Add`untuk menambahkan list buah ke dalam keranjang.
-   User bisa menekan tombol `Hapus` untuk menghapus list buah di dalam keranjang.
-   User akan mendapat notifikasi `Ops, keranjang penuh !` jika keranjang terisi penuh

## How does it works?

-   Terdapat folder Model yang berisikan class `Bucket.cs`,`BucketEventListener.cs`, `Fruit.cs`, dan `Seller.cs`
-   Terdapat`MainWindow.xaml`untuk menampilkan program
-   Terdapat folder Controller yang berisi class `BucketController.cs` 

Diawali dari Method `MainWindow` pada class `MainWindow.xaml.cs` kita mendeklarasikan
```C#
        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(4);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            Mardi = new Seller("Mardi", bucketController);

            ListBoxBucket.ItemsSource = keranjangBuah.findAll();

        }
```
