// Studi Kasus: Sistem Pemesanan Tiket Bioskop //
Deskripsi
Sistem ini dirancang untuk memesan tiket bioskop secara online. Sistem terdiri dari beberapa kelas yang saling berkaitan, termasuk pengguna, film, tiket, jadwal, dan pembayaran.

Class Diagram UML 

Relasi-relasi berikut digunakan:

Asosiasi:
Pengguna memesan satu atau lebih tiket.
Tiket terkait dengan satu jadwal pemutaran film tertentu.

Agregasi:
Tiket mengandung objek Film sebagai informasi deskriptif, namun film tetap ada meskipun tiket dihapus.

Komposisi:
Jadwal memiliki daftar tiket yang sepenuhnya dimilikinya (ketika jadwal dihapus, tiket juga dihapus).

Realisasi:
Pembayaran diimplementasikan oleh dua metode konkret: TransferBank dan DompetDigital.

Generalization/Inheritance:
Tiket memiliki subclass TiketReguler dan TiketVIP dengan properti tambahan.

Dependensi:
Jadwal bergantung pada objek Film untuk menentukan waktu pemutaran.




Detail Class
Pengguna
Mewakili orang yang melakukan pemesanan tiket.
Atribut: nama, email, nomorTelepon.
Relasi: Asosiasi dengan Tiket.

Tiket
Mewakili tiket yang dipesan.
Atribut: id, jenis, harga.
Relasi: Generalisasi/Inheritance dengan TiketReguler dan TiketVIP.
Relasi: Agregasi dengan Film, Komposisi dengan Jadwal.

Film
Informasi tentang film yang sedang diputar.
Atribut: judul, durasi, genre.
Relasi: Agregasi dengan Tiket, Dependensi dengan Jadwal.

Jadwal
Menentukan waktu dan lokasi pemutaran film.
Atribut: id, waktuMulai, waktuSelesai, ruangan.
Relasi: Komposisi dengan Tiket, Dependensi dengan Film.

Pembayaran
Interface yang digunakan untuk pembayaran tiket.
Implementasi: TransferBank, DompetDigital.
Metode: prosesPembayaran().
