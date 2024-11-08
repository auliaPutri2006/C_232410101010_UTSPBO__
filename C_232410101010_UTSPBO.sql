create table kategori_barang (
id serial primary key,
nama_kategori varchar(100) not null);

create table barang (
nama_barang varchar(100) not null,
jumlah int check (jumlah >= 0),
harga_barang int not null,
id_kategori int not null,
foreign key (id_kategori)references kategori_barang(id) on delete cascade);

insert into kategori_barang (nama_kategori) values ('rumah_tangga'),('pendidikan');

insert into barang (nama_barang,jumlah,harga_barang,id_kategori) values ('sendok',20,5000,1), ('garpu',30,7000,1),
('buku_tulis',30,4000,2);

select * from barang
