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

alter table Pendapatan alter column ketPendapatan varchar(20)

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

alter table Pengeluaran alter column ketPengeluaran varchar(20)

alter table Pendapatan alter column tglPendapatan date not null;
alter table Pengeluaran alter column tglPengeluaran date not null;
alter table Jurnal alter column tglJurnal date not null;

create table Jurnal(
idJurnal		char(10)		primary key,
tglJurnal		date default getdate()	not null,
noBukti			int				not null,
ketJurnal		text			not null
)

alter table jurnal alter column ketJurnal varchar(100)
alter table jurnal alter column tglJurnal date not null
alter table jurnal alter column noBukti char(6)

create table DetailJurnal(
idJurnal		char(10)		foreign key references Jurnal(idJurnal),
jnsNominal		char(1)			not null,
nominal			int				not null
)

alter table DetailJurnal add ref char(4)

create table Data(
idData			char(6),
namaData		char(100),
tanggalData		date,
jumlahData		int
)

alter table data alter column idData char(4)
alter table data alter column namaData varchar(100)
alter table Biaya add jnsSaldo char(1)


//INSERT
1 = admin
2 = user
3 = pemilik

insert into Userr values ('US0001','Pepmilik','123456789','pemilik','pemilik','3')
insert into Userr values ('US0002','Admin 1','0123456789','admin','admin','1')
insert into Userr values ('US0003','User 1','9876543210','user','user','2')

insert into Biaya values ('BY1101','Kas','')
insert into Biaya values ('BY4101','Pendapatan','')

delete from Userr
delete from Jurnal
delete from DetailJurnal
delete from DetailBiaya
delete from Pengeluaran

delete from Produk
select * from DetailJurnal
select * from Jurnal
select * from Pengeluaran

select * from DetailBiaya



 
//FUNCTION, TRIGGER, PROCEDURE

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

alter function FCKdPendapatan()
returns char(6) as 
begin
	declare @kdbaru char(6), @urut int
	select @urut =  ISNULL(max(right(idPendapatan,4)),0) from Pendapatan
	set @kdbaru = 'PD' + right('0000' + cast(@urut + 1 as varchar(4)),4)
	return @kdbaru
end
select dbo.FCKdPendapatan()
create function FCKdPengeluaran()
returns char(6) as 
begin
	declare @kdbaru char(6), @urut int
	select @urut =  max(right(idPengeluaran,4)) from Pengeluaran
	set @kdbaru = 'PL' + right('0000' + cast(@urut + 1 as varchar(4)),4)
	return @kdbaru
end

create function FCKdBiaya(@kel char(2))
returns char(6) as
begin
   declare @kdbaru char(6),@urut int
   select @urut= isnull(max(right(idBiaya,2)),0) from Biaya 
   where substring(idBiaya,3,2) = @kel
   set @kdbaru = 'BY' + @kel + right('00' + cast(@urut + 1 AS varchar(2)),2)
   return @kdbaru
end

create function FCKdJurnal(@tgl date)
returns char(10) as 
begin
	declare @kdbaru char(10), @urut int, @tahun char(4)
	set @tahun = convert(char(4),@tgl,12)
	select @urut =  isnull(max(right(idJurnal,4)),0) from Jurnal
	set @kdbaru = 'JR' + @tahun + right('0000' + cast(@urut + 1 as varchar(4)),4)
	return @kdbaru
end

create proc SPInsertJurnal(@tgl date, @nb char(6), @ket varchar(100))
as 
begin tran
	declare @id char(10)
	set @id = dbo.FCKdJurnal(@tgl)
insert into Jurnal values (@id, @tgl, @nb, @ket)
select @id
IF @@ERROR =0
COMMIT TRAN
ELSE
ROLLBACK TRAN

alter proc SpInsertDetailJurnal(@id char(10), @jns char(1), @no int, @rf char(4))
as 
begin tran
insert into DetailJurnal values (@id, @jns, @no, @rf)
IF @@ERROR =0
COMMIT TRAN
ELSE
ROLLBACK TRAN

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

create trigger TGJurnalPenjualan on Pendapatan for insert 
as declare @idP char(6), @jumlah int, @tgl date, @idJ char(10), @ref char(4), @ket varchar(10)
begin tran
select @idP = idPendapatan, @tgl = tglPendapatan, @jumlah = jmlPendapatan, @ket = ketPendapatan from inserted
set @idJ = dbo.FCKdJurnal(@tgl)

if @ket='Jasa'
	begin
		insert into Jurnal values(@idJ, @tgl, @idP, 'Diterima Pendapatan Jasa')
		insert into DetailJurnal values(@idJ, 'D', @jumlah, '1101')
		insert into DetailJurnal values(@idJ, 'K', @jumlah, '4101')
	end
else 
	begin
		insert into Jurnal values(@idJ, @tgl, @idP, 'Diterima Pendapatan Penjualan Produk')
		insert into DetailJurnal values(@idJ, 'D', @jumlah, '1101') --kas
		insert into DetailJurnal values(@idJ, 'K', @jumlah, '4101') --pendapatan
	end
IF @@error=0
 COMMIT TRANSACTION
ELSE
 ROLLBACK TRANSACTION


//SELECT

PENDAPATAN
select dj.ref, jr.ketJurnal, convert (varchar, jr.tglJurnal,106), dj.nominal
from Jurnal jr join DetailJurnal dj on dj.idJurnal = jr.idJurnal
where dj.ref = '4101' and convert (varchar, jr.tglJurnal,106) like '%juni%'

PENGELUARAN
select substring(b.idBiaya,3,4) as ref, b.namaBiaya as Keterangan, convert (varchar, pl.tglPengeluaran,106) as Tanggal, db.hargaBiaya as Jumlah
from Biaya b join DetailBiaya db on b.idBiaya = db.idBiaya
			 join Pengeluaran pl on pl.idPengeluaran = db.idPengeluaran where pl.tglPengeluaran like '%2020-06%'

select js.idJasa, js.namaJasa, dj.jumlahJasa, js.hargaJasa, dj.discJasa, pd.tglPendapatan, us.idUser, pd.idPendapatan
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

select b.idBiaya, b.namaBiaya, db.jumlahBiaya, db.hargaBiaya, pl.idPengeluaran, convert (varchar, pl.tglPengeluaran,106), us.idUser
from Biaya b join DetailBiaya db on b.idBiaya = db.idBiaya
			 join Pengeluaran pl on pl.idPengeluaran = db.idPengeluaran
			 join Userr us on us.idUser = pl.idUser 
			 where b.idBiaya = 'BY0001' and pl.tglPengeluaran between '2020-03-01' and '2020-03-01' 

select sum(jumlahData) as pengeluaran from data where idData not like '%BY%'

select top 5 * from Produk order by idProduk desc

select convert(varchar, tglJurnal,106) as Tanggal, ketJurnal from Jurnal

select j.idJurnal, convert(varchar, j.tglJurnal,106), dj.ref, b.namaBiaya,
	case dj.jnsNominal when 'D' then dj.nominal else 0 end as 'debet',
	case dj.jnsNominal when 'K' then dj.nominal else 0 end as 'kredit' 
from Jurnal J join DetailJurnal dj on j.idJurnal = dj.idJurnal
			  join Biaya b on substring(b.idBiaya,3,4) = dj.ref
			  where j.tglJurnal like '2020-06-01'
			  order by j.idJurnal ASC 

select * from Biaya where jnsSaldo != ''


select * from jurnal
