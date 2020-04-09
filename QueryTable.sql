create database ButikDaurUlang 
on ( name = ButikDaurUlangdat, 
filename = 'E:\#Kuliah\#SKRIPSI\QueryDB\ButikDaurUlang.mdf', 
size = 10MB, maxsize = 50MB, 
filegrowth = 5MB) 
log on ( name = DBSIAXXlog, 
filename = 'E:\#Kuliah\#SKRIPSI\QueryDB\ButikDaurUlang.ldf', 
size = 10MB, maxsize = 50MB, 
filegrowth = 5MB)
go

use ButikDaurUlang

Create table Userr (
idUser			char(6)			primary key,
namaUser		varchar(100)	not null,		
hpUser			varchar(20)		not null,
usernameUser	varchar(100)	not null,
passwordUser	varchar(100)	not null,
statusUser		char(1)			not null
)

create table Produk(
idProduk		char(6)			primary key,
namaProduk		varchar(100)	not null,
hargaProduk		int				not null,
stockProduk		int				not null
)

create table Jasa(
idJasa			char(6)			primary key,
namaJasa		varchar(100)	not null,
hargaJasa		int				not null
)

create table DetailProduk(
idProduk		char(6)			foreign key references Produk(idProduk),
idPendapatan	char(6)			foreign key references Pendapatan(idPendapatan),
jumlahProduk	int				not null,
discProduk		float			not null
)

create table DetailJasa(
idJasa			char(6)			foreign key references Jasa(idJasa),
idPendapatan	char(6)			foreign key references Pendapatan(idPendapatan),
jumlahJasa		int				not null,
discJasa		float			not null
)

create table Pendapatan(
idPendapatan	char(6)			primary key,
jmlPendapatan	int				not null,
ketPendapatan	text			null,
tglPendapatan	datetime		not null,
idUser			char(6)			foreign key references Userr(idUser)
)

create table Biaya(
idBiaya			char(6)			primary key,
namaBiaya		varchar(100)	not null
)

create table DetailBiaya(
idBiaya			char(6)			foreign key references Biaya(idBiaya),
idPengeluaran	char(6)			foreign key references Pengeluaran(idPengeluaran),
jumlahBiaya		int				not null,
hargaBiaya		int				not null
)

create table Pengeluaran(
idPengeluaran	char(6)			primary key,
jmlPengeluaran	int				not null,
ketPengeluaran	text			null,
tglPengeluaran	datetime		not null,
idUser			char(6)			foreign key references Userr(idUser)
)

create table Jurnal(
idJurnal		char(6)			primary key,
tglJurnal		datetime		not null,
noBukti			int				not null,
ketJurnal		text			not null
)

create table DetailJurnal(
idJurnal		char(6)			foreign key references Jurnal(idJurnal),
ref				char(4)			foreign key references RekAkun(idAkun),
jnsNominal		char(1)			not null,
nominal			int				not null
)

create table RekAkun(
idAkun			char(4)			primary key,
namaAkun		varchar(100)	not null,
jnsSaldo		char(1)			not null,
saldo			int				not null		
)


//INSERT

insert into Userr values ('US0001','admin','0857','admin1','1234','1')
insert into Userr values ('US0002','user','0856','user1','5678','2')
insert into Userr values ('US0003','admin2','0893','admin22222','9101','1')
insert into Userr values ('US0004','user2','0812','user111111','1112','2')
insert into Produk values ('PR0001','Ganci', 5000, 20)
insert into Produk values ('PR0002','bunga', 10000, 20)
insert into Jasa values ('JS0001','Aksesoris dari Plastik Kemasan (Produk)',350000)
insert into Biaya values ('BY0001','Biaya Kirim')
insert into Pendapatan values ('PD0001',15000,'','08 Feb 2020','US0002')
insert into Pendapatan values ('PD0002',700000,'','08 Feb 2020','US0002')
insert into Pendapatan values ('PD0003',10000,'','08 Feb 2020','US0005')
insert into Pengeluaran values ('PL0001',20000,'','08 Feb 2020','US0001')
insert into DetailProduk values ('PR0001','PD0001',1,1)
insert into DetailProduk values ('PR0002','PD0001',1,1)
insert into DetailProduk values ('PR0002', 'PD0003',1,1)
insert into DetailJasa values ('JS0001','PD0002',1,1)
insert into DetailJasa values ('JS0001','PD0005',2,1)
insert into Pendapatan values ('PD0005',700000,'','08 Feb 2020','US0001')
insert into DetailBiaya values ('BY0001','PL0001',1)

select * from DetailJasa order by idPendapatan desc

//FUNCTION

userr				US0001
produk				PR0001
jasa				JS0001
biaya				BY0001
pendapatan			PD0001
pengeluaran			PL0001
jurnal				JR0001
detailjurnal		DJ0001
rek akun			RA0001

create function FCKdUser()
returns char(6) as 
begin
	declare @kdbaru char(6), @urut int
	select @urut =  max(right(idUser,4)) from Userr
	set @kdbaru = 'US' + right('0000' + cast(@urut + 1 as varchar(4)),4)
	return @kdbaru
end

select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, pd.tglPendapatan, us.idUser, pd.idPendapatan
from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa
			 join Pendapatan pd on pd.idPendapatan = dj.idPendapatan
			 join Userr us on us.idUser = pd.idUser 


select * from Userr 