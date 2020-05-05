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


alter table DetailProduk alter column discProduk int not null;
alter table DetailJasa alter column discJasa int not null;

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

alter table Pendapatan alter column tglPendapatan date not null;
alter table Pengeluaran alter column tglPengeluaran date not null;
alter table Jurnal alter column tglJurnal date not null;

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

create table Data(
idData			char(6),
namaData		char(100),
tanggalData		date,
jumlahData		int
)

alter table data
//INSERT

insert into Userr values ('US0001','admin','0857','admin1','1234','1')
insert into Userr values ('US0002','user','0856','user1','5678','2')
insert into Userr values ('US0003','admin2','0893','admin22222','9101','1')
insert into Userr values ('US0004','user2','0812','user111111','1112','2')
insert into Userr values ('US0006', 'pemilik','0000','pemilik','pemilik','3')
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

INSERT INTO REKAKUN VALUES ('1101','Kas','D',0)
INSERT INTO REKAKUN VALUES ('1102','Piutang Dagang','D',0)
INSERT INTO REKAKUN VALUES ('1103','Persediaan Barang Dagangan','D',0)
INSERT INTO REKAKUN VALUES ('1104','Perlengkapan','D',0)
INSERT INTO REKAKUN VALUES ('1201','Peralatan','D',0)
INSERT INTO REKAKUN VALUES ('1202','Akm.Peny. Peralatan','D',0)
INSERT INTO REKAKUN VALUES ('1203','Kendaraan','D',0)
INSERT INTO REKAKUN VALUES ('1204','Akm.Peny. Kendaraan','D',0)
INSERT INTO REKAKUN VALUES ('2101','Hutang Dagang','K',0)
INSERT INTO REKAKUN VALUES ('2201','Hutang Bank','K',0)
INSERT INTO REKAKUN VALUES ('3101','Modal','K',0)
INSERT INTO REKAKUN VALUES ('4101','Penjualan','K',0)
INSERT INTO REKAKUN VALUES ('4102','Pot. Penjualan','K',0)
INSERT INTO REKAKUN VALUES ('5101','Pembelian','D',0)
INSERT INTO REKAKUN VALUES ('5102','Pot. Pembelian','D',0)
INSERT INTO REKAKUN VALUES ('6101','Biaya Listrik','D',0)
INSERT INTO REKAKUN VALUES ('6102','Biaya Gaji','D',0)

select ref from DetailJurnal where ref='6102'
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

create function FCKdAkun(@kel char(2))
returns char(4) as
begin
   declare @kdbaru char(4),@urut int
   select @urut= isnull(max(right(idAkun,2)),0) from RekAkun 
   where left(idAkun,2) = @kel
   set @kdbaru = @kel + right('0' + cast(@urut + 1 AS varchar(2)),2)
   return @kdbaru
end


select dbo.FCKdAkun(11)

select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, pd.tglPendapatan, us.idUser, pd.idPendapatan
from Jasa js join DetailJasa dj on js.idJasa = dj.idJasa
			 join Pendapatan pd on pd.idPendapatan = dj.idPendapatan
			 join Userr us on us.idUser = pd.idUser 


select db.idBiaya, pl.ketPengeluaran, db.idPengeluaran, db.jumlahBiaya, pl.tglPengeluaran 
from Pengeluaran pl join DetailBiaya db on pl.idPengeluaran = db.idPengeluaran
where pl.ketPengeluaran like '%B%' or db.idBiaya like '%B%'


select p.idProduk, p.namaProduk, dp.jumlahProduk, p.hargaProduk, dp.discProduk, dp.idPendapatan, pd.tglPendapatan, us.idUser
from Produk p 
join DetailProduk dp on p.idProduk = dp.idProduk
			  join Pendapatan pd on pd.idPendapatan = dp.idPendapatan
			  join Userr us on us.idUser = pd.idUser 
where dp.jumlahProduk like 1 or p.hargaProduk like 2


SELECT idUser, namaUSer, hpUser, usernameUser, passwordUser, case statusUser 
   WHEN '1' THEN 'Admin' 
   when '2' then 'User'
   end as 'Status User'
   FROM Userr where statusUser != '3' and 'Status User' like '%Admin%'

select idPendapatan, jmlPendapatan, ketPendapatan, CONVERT(varchar, tglPendapatan,106), idUser 
from Pendapatan where idPendapatan like '%PD0001%' and tglPendapatan between '2020-03-01' and '2020-03-01'

select idPengeluaran, jmlPengeluaran, convert(varchar, tglPengeluaran,106), idUser from Pengeluaran

select * from pengeluaran 

select b.idBiaya, b.namaBiaya, db.jumlahBiaya, db.hargaBiaya, pl.idPengeluaran, convert (varchar, pl.tglPengeluaran,106), us.idUser
from Biaya b join DetailBiaya db on b.idBiaya = db.idBiaya
			 join Pengeluaran pl on pl.idPengeluaran = db.idPengeluaran
			 join Userr us on us.idUser = pl.idUser 
			 where b.idBiaya = 'BY0001' and pl.tglPengeluaran between '2020-03-01' and '2020-03-01' 


create trigger TGUbahStock on DetailProduk
for insert 
as declare @id char(6), @jml int
begin transaction
select @id = idProduk, @jml = jumlahProduk FROM inserted
update Produk set stockProduk = stockProduk - @jml WHERE idProduk = @id
IF @@error=0
 COMMIT TRANSACTION
ELSE
 ROLLBACK TRANSACTION


select * from Produk
select * from Pendapatan
select * from Userr

insert into Pendapatan values('PD0012', 10000, 'produk', '2020-05-05', 'US0002')
insert into DetailProduk values('PR0001', 'PD0012', 2, 0)


