create table userinfo (
                          account char(6),
                          password varchar(20) not null,
                          username varchar(20) not null,
                          authority int not null,
                          uid int identity(1,1) not null primary key ,
                          telephone varCHAR(12) NOT NULL ,
                          theme varchar(20) not null
)


    insert into userinfo(account,password,username,authority,telephone,theme) values
('10000','123456','宇峰',1,'15181352020','248, 172, 89'),
('10001','123456','风清扬',2,'15181452020','248, 172, 89'),
('10002','123456','欧阳锋',3,'15183352020','248, 172, 89'),
('10003','123456','扶苏',1,'15181552020','248, 172, 89'),
('10004','123456','杨过',2,'15181351020','248, 172, 89'),
('10005','123456','令狐冲',3,'15381352020','248, 172, 89')

select * from userinfo

create table tomato (
                        tdnum int identity(1,1) primary key ,
                        tdname varchar(15) not null,
                        tdtime DATETIME  NOT NULL,
                        tdlenth int not null,
                        tdtype varchar(10) default '逆时针',
                        tdcounter int default 0,
                        uid int not null,
                        foreign key(uid) references userinfo(uid)
)
    insert into tomato(tdname,tdtime,tdlenth,tdtype,uid) values
('代办1','2021-11-23 11:52:23.000',25,'逆时针',1),
('代办2','2021-11-23 11:52:57.000',25,'逆时针',1),
('代办3','2021-11-23 11:53:02.000',25,'逆时针',2),
('代办4','2021-11-23 11:53:07.000',25,'逆时针',2),
('代办5','2021-11-23 11:57:49.000',25,'逆时针',3),
('代办6','2021-12-09 19:18:20.000',25,'逆时针',3),
('代办7','2021-12-09 23:35:22.000',25,'逆时针',4),
('代办8','2021-12-09 23:35:26.000',25,'逆时针',5),
('代办9','2021-12-09 23:35:37.000',25,'逆时针',1),
('代办10','2021-12-09 23:35:41.000',25,'逆时针',3),
('代办11','2021-12-09 23:35:46.000',25,'逆时针',1),
('代办12','2021-12-09 23:38:52.000',25,'逆时针',2),
('代办13','2021-12-09 23:38:55.00', 25,'逆时针',1)
('英语作业'	     ,'2021-11-23 11:52:23.000',25,'逆时针',3),
('数学作业'	     ,'2021-11-23 11:52:57.000',25,'逆时针',3),
('计量经济学作业'   ,'2021-11-23 11:53:02.000',25,'逆时针',1),
('数据库作业'     ,'2021-11-23 11:53:07.000',25,'逆时针',1),
('保险学作业'	 ,'2021-11-23 11:57:49.000',25,'逆时针',1),
('python作业'  ,'2021-12-09 19:18:20.000',25,'逆时针',1),
('java作业'    ,'2021-12-08 23:35:22.000',25,'逆时针',1),
('听歌'	     ,'2021-12-06 23:35:26.000',25,'逆时针',1)
select * from tomato


create table bills (
                       bnum int identity(1,1) primary key ,
                       bname varchar(15) not null,
                       btime DATETIME  NOT NULL,
                       btype varchar(10) ,
                       bvalue int default 0,
                       uid int not null,
                       foreign key(uid) references userinfo(uid)
)
insert into bills(bname,btime,btype,uid) values
('消费1','2021-11-23 11:52:23.000','食品支出',1),
('消费2','2021-11-23 11:52:57.000','食品支出',1),
('消费3','2021-11-23 11:53:02.000','食品支出',1),
('消费4','2021-11-23 11:53:07.000','食品支出',1),
('消费5','2021-11-23 11:57:49.000','食品支出',1),
('消费6','2021-12-09 19:18:20.000','食品支出',1),
('消费7','2021-12-09 23:35:22.000','食品支出',1),
('消费8','2021-12-09 23:35:26.000','食品支出',1),
('消费9','2021-12-09 23:35:37.000','食品支出',1),
('消费10','2021-12-09 23:35:41.000','食品支出',1),
('消费11','2021-12-09 23:35:46.000','食品支出',1),
('消费12','2021-12-09 23:38:52.000','食品支出',1),
('消费13','2021-12-09 23:38:55.00', '食品支出',1)
select * from bills




create view tmtsta as
select userinfo.uid,userinfo.username as 用户名,tdname as 代办名称,tdlenth as 代办时长 ,tdtime as 创建时间, tdcounter as 完成次数
from userinfo,tomato where userinfo.uid=tomato.uid

create view billsta as
select userinfo.uid,bvalue as 消费金额, userinfo.username as 用户名,bname as 账单名称,btime as 创建时间, btype as 消费类型
from userinfo,bills where userinfo.uid=bills.uid

create view user_view as
select uid as 编号,account as 账号,password as 密码,username as 用户名,authority as 权限, telephone as 电话号码 from userinfo

CREATE  TRIGGER TA
    ON userinfo
    FOR INSERT
AS
DECLARE @_account AS CHAR(6)
SELECT @_account=i.account FROM inserted I
    if not exists(select * from userinfo where account=@_account)
		print '插入成功'
	 ELSE
BEGIN
				PRINT '重复账号,不能插入'
				ROLLBACK
END
