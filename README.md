# 宇峰管理系统

* 小组成员:唐宇峰   
* 年级:2019级  
* 专业:金融学 
* 指导教师:袁科萍  
* 日期:2021年12月24日
* GitHub地址:https://github.com/dirichlet007/Management

## 一 项目设计的目的和意义

​	深感于自己疏于个人时间管理和财务管理,于是决定借助计算机技术,做出一个私人的管理系统,可依照自身需求,创建代办,创建之后可按照番茄规律,进行番茄钟专注,进行自我管理.同时帮助用户克制不必要消费支出的欲望,对自身财物状况进行深刻了解,该管理系统设计了一个记账板块,可以实现用户的记账需求,并通过统计报表呈现.最后,希望此系统能协助用户实现自我管理.

## 二 项目主要功能描述

### 1 登陆功能

​	用户需要在登陆界面,输入正确的账号与密码,才能登陆进入主界面.同时,为了方便用户使用,设计了记住密码和账号的功能.如果用户忘记密码,可以点击忘记密码,寻求开发者的支持.

![image-Login](/Image/Login.png)

### 2 主页面

​	主页面会根据用户权限,动态生成用户名以及对应权限,同时,在主页面的侧边栏中,含有导航按钮,用户点击不同的导航按钮,可以实现主页面中panel的改变

![image-20211223141458060](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211223141458060.png)

### 3 番茄钟页面

​	番茄钟页面会根据用户的id,自动检索用户创建的代办信息,并生成番茄钟的按钮列表.在右上角,有添加代办的按钮,用户可以通过点击按钮,实现自定义添加番茄钟,每一行番茄钟具有开始按钮,点击可以打开番茄计时的窗口,实现用户的番茄专注功能.

![image-20211223141522313](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211223141522313.png)

### 4 添加代办页面

​	添加代办页面,会根据用户输入的代办名称,在后台数据库生存相应数据并保存.

![image-20211223141613737](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211223141613737.png)

### 5 番茄专注页面

​	用户点击番茄列表中的开始按钮之后,可以开始进行番茄专注,番茄专注会根据你输入的专注时间,自动按该时长计时,在计时阶段,番茄钟会播放舒缓人心的雨声,在计时完成时,番茄钟会播放醒神的闹钟,同时对窗体进行抖动,提示用户.

![image-20211224082639929](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224082639929.png)

### 6 番茄统计页面

​	番茄统计页面,会根据用户的番茄钟完成次数,计算用户每个番茄的总时长,并在左下角生成饼图.为了方便用户进行直观的统计,可以根据需求,生成今日统计,本周统计,以及年度统计,同时,为了方便管理员进行管理,,含有详细统计按钮.可以查看所有用户的详细代办信息

​	![image-20211223143229442](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211223143229442.png)

### 7 账单页面

​	账单页面,会根据用户输入的账单信息,在后台数据库生存相应数据并保存.

![image-20211223204911297](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211223204911297.png)

### 8 账单统计页面

​	账单统计页面,会根据用户的消费信息,自动分类并统计金额,为了更直观的观察,在左下角生成饼图.如果用户想要根据时间线进行直观的统计,可以点击不同按钮,生成今日统计,本周统计,以及年度统计,同时,为了方便管理员进行管理,含有详细统计按钮,可以查看所有用户的详细消费信息

![image-20211224083405417](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224083405417.png)

### 9 系统主题页面

​	为了使用户不对千篇一律的主题颜色感到枯燥,系统设置了系统主题更改页面,用户可以在此页面实现用户主题颜色的切换,同时,该信息会传入数据库,并在数据库进行存储,用户在重新打开面板时,程序会读取数据库中存储的主题颜色,并进行相应的加载.

![image-20211223144327389](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211223144327389.png)

### 10 用户管理

​	考虑到多人使用的情况,设计了用户管理页面,只有超级管理员有权限可以进入,管理员可以在此页面对用户进行管理,进行用户的增删改查.

![image-20211223144940203](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211223144940203.png)

## 三 数据库设计

### 1．数据需求分析

​	通过对用户的操作,对数据需求的分析如下:

* 用户表userinfo
  * 主要存储用户的相关信息
* 番茄表tomato
  * 主要储存番茄代办相关信息
* 账单表bills
  * 主要储存账单相关信息

用户创建番茄代办,记录账单信息

### 2．概念模式设计

​	根据数据需求分析,对数据库的外在逻辑进行抽象,得出如下的ER图(ps:由于工具原因,无法在主键下进行标注)

![ER图](/Users/tangyufeng/Downloads/ER图.png)

### 3．逻辑模式设计

* userinfo
  * 主键:uid
* tomato
  * 主键:tdnum
  * 外键:uid
* bills
  * 主键:bnum
  * 外键:uid

### 4．数据库实施

* 数据库创建

```sql
create database Management
```

* 创建userinfo表

```sql
create table userinfo (
                          account char(6),
                          password varchar(20) not null,
                          username varchar(20) not null,
                          authority int not null,
                          uid int identity(1,1) not null primary key ,
                          telephone varCHAR(12) NOT NULL ,
                          theme varchar(20) not null
)
```

* 插入数据到userinfo表

```sql
insert into userinfo(account,password,username,authority,telephone,theme) values
('10000','123456','宇峰',1,'15181352020','248, 172, 89'),
('10001','123456','风清扬',2,'15181452020','248, 172, 89'),
('10002','123456','欧阳锋',3,'15183352020','248, 172, 89'),
('10003','123456','扶苏',1,'15181552020','248, 172, 89'),
('10004','123456','杨过',2,'15181351020','248, 172, 89'),
('10005','123456','令狐冲',3,'15381352020','248, 172, 89')
```

* 创建tomato表

```sql
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
```

* 插入数据到tomato表

```sql
insert into tomato(tdname,tdtime,tdlenth,tdtype,uid) values
('英语作业'	     ,'2021-11-23 11:52:23.000',25,'逆时针',3),
('数学作业'	     ,'2021-11-23 11:52:57.000',25,'逆时针',3),
('计量经济学作业'   ,'2021-11-23 11:53:02.000',25,'逆时针',1),
('数据库作业'     ,'2021-11-23 11:53:07.000',25,'逆时针',1),
('保险学作业'	 ,'2021-11-23 11:57:49.000',25,'逆时针',1),
('python作业'  ,'2021-12-09 19:18:20.000',25,'逆时针',1),
('java作业'    ,'2021-12-08 23:35:22.000',25,'逆时针',1),
('听歌'	     ,'2021-12-06 23:35:26.000',25,'逆时针',1)
```

* 创建bills表

```sql
create table bills (
                       bnum int identity(1,1) primary key ,
                       bname varchar(15) not null,
                       btime DATETIME  NOT NULL,
                       btype varchar(10) ,
                       bvalue int default 0,
                       uid int not null,
                       foreign key(uid) references userinfo(uid)
)
```

* 插入数据到bills表

```sql
insert into bills(bname,btime,btype,bvalue,uid) values
('消费1	','2021-11-23 11:52:23.000','衣服饰品	',1,34), 
('消费2	','2020-11-23 11:52:57.000','食品酒水	',1,123),
('消费3	','2020-11-23 11:53:02.000','食品酒水	',1,345),
('消费4	','2021-11-23 11:53:07.000','食品酒水	',1,65),
('消费5	','2020-11-23 11:57:49.000','金融保险	',1,67),
('消费6	','2021-12-09 19:18:20.000','衣服饰品	',1,87),
('消费7	','2021-12-09 23:35:22.000','金融保险	',1,543),
('消费8	','2020-12-09 23:35:26.000','金融保险	',1,345),
('消费9	','2021-12-09 23:35:37.000','衣服饰品	',1,345),
('消费10','2021-12-09 23:35:41.000','行车交通',1,435),
('消费11','2021-12-09 23:35:46.000','休闲娱乐',1,76),
('消费12','2021-12-09 23:38:52.000','行车交通',1,65),
('消费13','2021-12-09 23:38:55.000','休闲娱乐',1,123),
('消费14','2021-12-13 19:21:21.000','衣服饰品',1,312),
('消费15','2021-12-13 19:22:22.000','衣服饰品',1,435)
```

* 创建用户信息视图

```sql
create view user_view as
select uid as 编号,account as 账号,password as 密码,username as 用户名,authority as 权限, telephone as 电话号码 from userinfo
```

* 创建番茄统计视图

```sql
create view tmtsta as
select userinfo.uid,userinfo.username as 用户名,tdname as 代办名称,tdlenth as 代办时长 ,tdtime as 创建时间, tdcounter as 完成次数
from userinfo,tomato where userinfo.uid=tomato.uid
```

* 创建账单统计视图

```sql
create view billsta as
select userinfo.uid,bvalue as 消费金额, userinfo.username as 用户名,bname as 账单名称,btime as 创建时间, btype as 消费类型
from userinfo,bills where userinfo.uid=bills.uid
```

* 创建触发器---防止创建相同账号

```sql
CREATE  TRIGGER TA
    ON userinfo
    FOR INSERT
AS
DECLARE @_account AS CHAR(6)
SELECT @_account=i.account FROM inserted I
    if (select count(*) from userinfo where account=@_account)<=1
		print '插入成功'
	 ELSE
BEGIN
				PRINT '重复账号,不能插入'
				ROLLBACK
END
```

* 创建触发器---防止创建同名代办

```sql
CREATE  TRIGGER TB
    ON tomato
    FOR INSERT
AS
DECLARE @_tdname AS varCHAR(15)
SELECT @_tdname=i.tdname FROM inserted I
    if (select count(*) from tomato where tdname=@_tdname)<=1
		print '插入成功'
	 ELSE
BEGIN
				PRINT '重复代办,不能插入'
				ROLLBACK
END
```

## 四 窗体设计与功能设计程序标注

### 1 功能类集合

​	为了增强代码的复用性,将常用的一些操作,例如:窗体的嵌套代码,以及数据库的调用代码,这部分代码由于被大量的使用.于是将其提取,把数据库操作以及窗体类操作封装为特定的功能类.以降低程序的内聚性,增强程序的耦合性.

#### 1.1 子父窗体嵌套

​	这部分代码,由袁科萍老师而指导而形成.

```c#
public void closeFrm(Panel panelmain//关闭panel中的窗体--panelmain是panel的名称
        {
            foreach (Control item in panelmain.Controls)
            {
                if (item is Form)
                {
                    Form form = (Form)item;
                    form.Close();
                    panelmain.Controls.Remove(form);
                }
            }
        }
public void openFrm(Form frm, Panel panelmain)    //在panel中打开窗体
        {
            frm.TopLevel = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Parent = panelmain;
            frm.Show();
        }
```

​	代码逻辑主要是通过panel进行窗体的嵌套,首先,对每一个在panelmain中存在的控件进行判断,然后遍历移除.接着将form传入panel中,然后设置边框为无,设置最大化以及dock设置为fill,最后声明父窗体

#### 1.2 数据库功能集合

​	项目中大量调用数据库连接,许多代码高度重复,于是,借鉴Java编程思想,对这一部分代码作出整合,抽象为一个DBUtil类

```c#
 class DBUtil
    {
        string connectString = "Data=Source=DIRICHLET;Initial=Catalog=Management;Integrated Security=True";
        public SqlConnection conn;
        public void SqlQuery(string sql)
        {
            conn = new SqlConnection(connectString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataSet SqlSet(string sql)
        {
            //创建 SQLConnection 的实例
            SqlConnection conn = null;
            conn = new SqlConnection(connectString);
            //打开数据库连接
            conn.Open();
            //创建 SQLDataAdapter 类的对象
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            //创建DataSet类的对象
            DataSet ds = new DataSet();
            //使用SQLDataAdapter对象sda将查询结果填充到Dataset对象ds中
            sda.Fill(ds);
            conn.Close();
            return ds;
        }
        public bool SqlCheck(string sql)
        {
            bool tag = false;
            conn = new SqlConnection(connectString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                int result1 = Convert.ToInt32(cmd.ExecuteScalar());
                if (result1 > 0)
                {
                    tag = true;
                }
                return tag;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {

                conn.Close();
            }
        }
    }
```

数据库功能类被我划分为三类:

* SqlQuery
  * 这一类sql命令,主要是增加 删除 更新 等命令,这一部分命令,没有返回值,只需要设置传入的SQL语句即可,同时,不需要设置返回值
* Sqlset
  * 这一类的命令,需要一个返回的数据集,设置返回数据类型为DataSet
* SqlCHeck
  * 这一类的命令,需要返回布尔值,主要用于判读数据库内部是否存在对应值,主要用于权限检验

### 2 登录_Login

#### 2.1 页面UI设计

​	页面的UI主要采用panel面板填充,同时选择picturebox选择经过Ps抠图后的老虎图像作为主题图片.同时,为了防止窗体过于陈旧,将FormBorderStyle改为None,人为的增加关闭按钮,并为其添加关闭窗体事件

![image-20211223161359225](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211223161359225.png)

#### 2.2 登录功能

* 检查用户名密码

```c#
private bool Check()
{
            if (txtName.Text.Trim().Equals("") || txtName.Text == null)
            {
                MessageBox.Show("请输入用户名！\t", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            else if (txtPassword.Text.Trim().Equals("") || txtPassword.Text == null)
            {
                MessageBox.Show("请输入密码！\t", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            else
            {
                return true;
            }
}
```

​	检查用户名密码是否为空,如果为空,则提示用户进行输入,并聚焦到空的文本框,增强用户体验

* 判断用户密码是否正确

```c#
        DBUtil db = new DBUtil();
        private void button1_Click_1(object sender, EventArgs e)
        {
            string account = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (Check())
            {
                button1.Text = "正在登录...";
                string sql = string.Format(@"select count(*) from userinfo where account='{0}'and password ='{1}'", account, password);
                string sql2 = string.Format(@"select username,authority,theme,uid from userinfo where account='{0}'and password ='{1}'", account, password);
                if (db.SqlCheck(sql))
                {

                    DataSet ds = db.SqlSet(sql2);
                    label1.Text = ds.Tables[0].Rows[0][0].ToString();
                    DashBoard fs = new DashBoard();
                    fs.username = ds.Tables[0].Rows[0][0].ToString();
                    fs.authority = ds.Tables[0].Rows[0][1].ToString();
                    fs.theme = ds.Tables[0].Rows[0][2].ToString();
                    fs.uid = ds.Tables[0].Rows[0][3].ToString();
                    fs.Show();
                    button1.Text = "登录";
                }
                else
                {
                    MessageBox.Show("密码或账号错误,请重新输入");
                }
            }
        }
```

​	首先,引用之前书写的DB功能类,创建实例化对象db,在登录按钮的事件中,如果满足账号密码不为空的条件,则开始通过sql检查是否存在对应的账号密码,如果存在,创建DashBoard窗体,并对DashBoard的公共变量进行赋值.

* 记住密码

​	为了方便用户的使用体验,创建记住密码的相关功能,大致思路如下:

```c#
            if (Check())
            {
                if (this.cb.Checked) //如果选中了则执行记录账号和密码操作
                {
                    WriteIn();
                }
                else
                {
                    ClearConfig();
                }

            }
```

​	如果用户的记住密码的状态改变,则检查是否输入了用户与密码,如果选中,则写入到文件中,如果未选中,则清空文件

1. 写入文档

```c#
        //写入文档
        private void WriteIn()
        {
            string File = Application.StartupPath;
            MessageBox.Show(File);
            string path = File.Substring(0, File.Length - 9) + "\\id_pwd\\PasswordConfig.txt";
            //找到储存登录密码的文件路径
            string content = this.txtName.Text.Trim() + "," + this.txtPassword.Text.Trim() + ",1";
            //储存信息
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write(content);  //写入文档
            sw.Close();
            fs.Close();
        }
```

2. 读取文档

```c#
            //先将内容读取出来
            string File = Application.StartupPath;
            string path = File.Substring(0, File.Length - 9) + "id_pwd\\PasswordConfig.txt";
            //找到储存登录密码的文件路径
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            string content = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            //对内容进行分割处理
            if (content != "")
            {
                string[] pwd_id = content.Split(',');
                this.txtName.Text = pwd_id[0];  //将内容写进文本框中
                this.txtPassword.Text = pwd_id[1];
                if (pwd_id[2] == "1")
                {
                    this.cb.Checked = true;
                }
            }
        }
```

 	在窗口加载内部调用ReadOut()函数

3. 清空文档

```c#
        private void ClearConfig()
        {
            string File = Application.StartupPath;
            string path = File.Substring(0, File.Length - 9) + "id_pwd\\PasswordConfig.txt";
            //找到储存登录密码的文件路径
            string content = "";
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write(content);  //写入文档
            sw.Close();
            fs.Close();
        }
```

#### 2.3 联系开发人员

​	为了防止忘记密码,可以打开点击联系作者以及忘记密码选项,可以弹出与作者的qq对话框

```c#
System.Diagnostics.Process.Start("http://wpa.qq.com/msgrdv=3&uin=1508022928&site=qq&menu=yes");
       
```

### 3 仪表盘_DashBoard

#### 3.1 页面加载

​	为了给页面加载出初始化的主题颜色,用户id,用户权限等等,设计一系列公有变量,并在前文的Login处赋值

```c#
        public string username;
        public string authority;
        public string theme;
        public string uid;
```

​	赋值过后,在窗体的Load函数中进行初始化加载

```c#
        private void DashBoard_Load(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(theme.Split(',')[0]);
            int num2 = Convert.ToInt32(theme.Split(',')[1]);
            int num3 = Convert.ToInt32(theme.Split(',')[2]);

            timer5.Start();
            Color c = Color.FromArgb(num1, num2, num3);
            labeltitle.Text = "欢迎！" + username;
            if (authority == "1")
            { label4.Text = "权限:  超级管理员"; }
            else if (authority == "2")
            { label4.Text = "权限:  普通管理员"; }
            else if (authority == "3")
            {
                label4.Text = "权限:  用户";
            }
            ChangeColor(c);
        }
```

#### 3.2 侧边栏折叠

​	设计侧边栏的动态折叠功能,主要依靠timer控件.获取到侧边栏的长度,然后通过timer的特性,每秒减去恒定的长度,如果小于某值,则停止.同理,展开也是相同的原理

```c#
        int PanelWidth;
        bool isCollapsed;
				private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 16;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer2.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 16;
                if (panelLeft.Width <= 64)
                {
                    timer2.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

```

#### 3.3  加载主题

​	设计changecolor函数,为一系列的控件改变其底色,实现用户主题的改变

```c#
        public void ChangeColor(Color c)
        {
            this.toppanel.BackColor = c;
            this.btnclose.BackColor = c;
            this.panelLeft.BackColor = c;
            this.labeltitle.BackColor = c;
            this.btnMain.BackColor = c;
            this.btnTomato.BackColor = c;
            this.btnTomatoStatistic.BackColor = c;
            this.btnBills.BackColor = c;
            this.btnBillsStatistic.BackColor = c;
            this.btnSystemSet.BackColor = c;
            this.btnManager.BackColor = c;
            this.btn.BackColor = c;
            this.btnfold.BackColor = c;
            this.label1.ForeColor = c;
            this.label4.BackColor = c;
        }
```

#### 3.4 嵌套窗体

​	为实现美化的嵌套效果,使用之前提到过的FormHelper功能类的函数进行嵌套,首先,创建他的实例化对象

```c#
        FormHelper fmhpr = new FormHelper();
```

​	然后进行窗体嵌套实例

```c#
            Main fs = new Main();
            fmhpr.closeFrm(panelmain);
            fmhpr.openFrm(fs, panelmain);
```

#### 3.5 权限控制

​	系统具有权限控制,超级管理员具有所有功能,而普通用户的功能则会受限.具体逻辑是在登录时传入用户的权限,再在打开按钮时先进行权限判断

```c#
            if (authority == "1")
            {
                UserManager fs = new UserManager();
                fmhpr.closeFrm(panelmain);
                fmhpr.openFrm(fs, panelmain);
            }
            else {
                MessageBox.Show("您没有对应权限!");
            }
```

全部代码如下

```c#
        public string username;
        public string authority;
        public string theme;
        public string uid;
        FormHelper fmhpr = new FormHelper();
        int PanelWidth;
        bool isCollapsed;
        public DashBoard()
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;

        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(theme.Split(',')[0]);
            int num2 = Convert.ToInt32(theme.Split(',')[1]);
            int num3 = Convert.ToInt32(theme.Split(',')[2]);

            timer5.Start();
            Color c = Color.FromArgb(num1, num2, num3);
            labeltitle.Text = "欢迎！" + username;
            if (authority == "1")
            { label4.Text = "权限:  超级管理员"; }
            else if (authority == "2")
            { label4.Text = "权限:  普通管理员"; }
            else if (authority == "3")
            {
                label4.Text = "权限:  用户";
            }
            ChangeColor(c);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 16;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer2.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 16;
                if (panelLeft.Width <= 64)
                {
                    timer2.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Main fs = new Main();
            fmhpr.closeFrm(panelmain);
            fmhpr.openFrm(fs, panelmain);
        }
        public void ChangeColor(Color c)
        {
            this.toppanel.BackColor = c;
            this.btnclose.BackColor = c;
            this.panelLeft.BackColor = c;
            this.labeltitle.BackColor = c;
            this.btnMain.BackColor = c;
            this.btnTomato.BackColor = c;
            this.btnTomatoStatistic.BackColor = c;
            this.btnBills.BackColor = c;
            this.btnBillsStatistic.BackColor = c;
            this.btnSystemSet.BackColor = c;
            this.btnManager.BackColor = c;
            this.btn.BackColor = c;
            this.btnfold.BackColor = c;
            this.label1.ForeColor = c;
            this.label4.BackColor = c;
        }


        private void btnbookmanage_Click(object sender, EventArgs e)
        {
            Tomato fs = new Tomato();
            fs.uid = uid;
            fmhpr.closeFrm(panelmain);
            fmhpr.openFrm(fs, panelmain);

        }
        private void btnsystemset_Click(object sender, EventArgs e)
        {
            SystemSettings fs = new SystemSettings();
            fs.change += new SystemSettings.ChangeMainForm(ChangeColor);

            fmhpr.closeFrm(panelmain);
            fmhpr.openFrm(fs, panelmain);

        }


        private void btnreader_Click(object sender, EventArgs e)
        {
            TomatoStatistics fs = new TomatoStatistics();
            fs.uid = uid;
            fmhpr.closeFrm(panelmain);
            fmhpr.openFrm(fs, panelmain);
        }

        private void btnqueryinfo_Click(object sender, EventArgs e)
        {
            BillsStatistics fs = new BillsStatistics();
            fs.uid = uid;
            fmhpr.closeFrm(panelmain);
            fmhpr.openFrm(fs, panelmain);

        }

        private void btnborrow_Click(object sender, EventArgs e)
        {
            Bills fs = new Bills();
            fs.uid = uid;
            fmhpr.closeFrm(panelmain);
            fmhpr.openFrm(fs, panelmain);
        }

        private void btnManager_Click(object sender, EventArgs e)
        {

            if (authority == "1")
            {
                UserManager fs = new UserManager();
                fmhpr.closeFrm(panelmain);
                fmhpr.openFrm(fs, panelmain);
            }
            else {
                MessageBox.Show("您没有对应权限!");
            }
        }
```



### 4 番茄钟_Tomato

#### 4.1 添加代办

​	通过添加代办的按钮,可以实现新窗体的创建,也就是AddBacklog窗体,下面详细介绍AddBacklog

![image-20211223190908329](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211223190908329.png)

​	代办会有默认的一些填写,当然,你也可以按照你自己的想法进行更改,确认添加之前,会有check函数,检验这些文本框不为空

```c#
private bool check()
{
            if (this.rtbname.Text == "")
            {
                MessageBox.Show("请输入待办名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.rtbname.Focus();
                return false;
            }
            else if (this.cnttype.Text=="") {
                MessageBox.Show("请输入计时类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cnttype.Focus();
                return false;
            }
            else if (this.rtbtime.Text == "")
            {
                MessageBox.Show("请输入待办时长！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.rtbtime.Focus();
                return false;
            }
            else if (this.bcltype.Text == "")
            {
                MessageBox.Show("请输入待办类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.bcltype.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
```

​	接着就调用数据库,将内容提取后插入

```c#
private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string tdname = rtbname.Text.Trim();
                string tdtype = cnttype.Text.Trim();
                string uid = "1";
                string tdlenth = rtbtime.Text.Trim().Substring(0, 2);
                string tdtime = DateTime.Now.ToString();
                DBUtil db = new DBUtil();
                string sql = string.Format(@"INSERT INTO tomato(tdname,tdtype,tdlenth,tdtime,uid)
                    VALUES ('{0}','{1}',{2},'{3}','{4}');", tdname, tdtype, tdlenth, tdtime, uid);
                db.SqlQuery(sql);
                refresh();
                this.Close();
            }
        }

```

​	最后是清空按钮,简单的绑定一些clear事件

```c#
        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbname.Clear();
            cnttype.Clear();
            bcltype.Clear();
            rtbtime.Clear();
        }
```

#### 4.2 遍历代办

​	为了增强系统的美感,我借鉴了手机版番茄钟的样式,然后自己设计了一个显示的控件,如下图

![image-20211223193437857](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211223193437857.png)

​	为了传入变量,于是为他传入一些公共变量,显示文字

```c#
        public string label1_text;
        public string label2_text;
        public string tdtime;
        public string uid;
        private void mybutton_Load(object sender, EventArgs e)
        {
            label1.Text = label1_text;
            label2.Text = label2_text;
        }
```

​	同时,该控件内部会打开计时窗体,需要传入一些参数,具体作用,后续在番茄专注中再谈

```c#
            TimeCounter fs = new TimeCounter();
            fs.uid = uid;
            fs.Attentiontime = Convert.ToInt32(tdtime)*60;
            fs.tdname = label1_text;
            fs.Show();
```

​	然后为了在Tomato内部显示出一系列的该控件,于是对panel进行设置,如果超出,则嵌入滚轮

```c#
this.AutoScrollMinSize =new Size(ClientRectangle.Width,ClientRectangle.Height);
           
```

​	然后就是从数据库中读取番茄信息并显示的代码

```c#
        class Tmtinfo
        {
            public string tmtname;
            public string tmttype;
        }        

public void textdisplay() {

            List<Tmtinfo> bls = new List<Tmtinfo>();
            DBUtil db = new DBUtil();
            string sql = string.Format(@"select tdname,tdtype,tdlenth from tomato order by tdnum desc ");
            DataSet ds = db.SqlSet(sql);
            var location = panel1.Location;
            try
            {
                DataTable myTable = ds.Tables[0];
                foreach (DataRow myRow in myTable.Rows)
                {
                    //遍历表中的每个单元格
                    Tmtinfo u = new Tmtinfo();
                    u.tmtname = myRow[0].ToString();
                    u.tmttype = myRow[1].ToString();
                    mybutton btn = new mybutton();
                    btn.uid = uid;
                    btn.tdtime = myRow[2].ToString();
                    btn.label1_text = u.tmtname;     
                    btn.label2_text = u.tmttype;
                    location.Y += 110;
                    btn.Location = new Point(location.X, location.Y);
                    panel1.Controls.Add(btn);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }
```

​	创建一个番茄信息的类,再创建以该类为基本元素的集合,但后面部分用到这个集合存储的地方较少,可能会比较耗费内存,于是把他给优化掉.这次经历,主要是因为最开始没有学习dataset,所以调用了集合来存储,于是,最终成型的代码如下:

```c#
       /* class Tmtinfo
        {
            public string tmtname;
            public string tmttype;
        }*/
        FormHelper fmhpr = new FormHelper();
        public void textdisplay() {

            //List<Tmtinfo> bls = new List<Tmtinfo>();
            DBUtil db = new DBUtil();
            string sql = string.Format(@"select tdname,tdtype,tdlenth from tomato order by tdnum desc ");
            DataSet ds = db.SqlSet(sql);
            var location = panel1.Location;
            try
            {
                DataTable myTable = ds.Tables[0];
                foreach (DataRow myRow in myTable.Rows)
                {

                    //遍历表中的每个单元格
                    //Tmtinfo u = new Tmtinfo();
                   // u.tmtname = myRow[0].ToString();
                   // u.tmttype = myRow[1].ToString();
                    mybutton btn = new mybutton();
                    btn.uid = uid;
                    btn.tdtime = myRow[2].ToString();
                    btn.label1_text = myRow[0].ToString();
                    btn.label2_text = myRow[1].ToString();
                    location.Y += 110;
                    btn.Location = new Point(location.X, location.Y);
                    panel1.Controls.Add(btn);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
```

​	将一些不需要的数据给注释掉,极大的优化了内存占用,如果后续需要调用,也可以直接获取text 的属性数据.这里核心的代码,是获取出panel1的位置,然后根据mybutton的长度,依次增加Y的位置点,然后添加button进入panel1

#### 4.3 番茄专注

​	为进行番茄专注,设置了Timecounter窗体,并可以通过mybutton中的开始按钮打开相应的窗体,并在完成后累计次数

![image-20211223201632062](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211223201632062.png)

​	进入Timecounter后,开始显示倒计时,还伴随着舒缓的雨声,雨声主要是通过c#自带的player进行播放,但要注意只能播放wav文件.同时,在计时完成后,会开始播放一段闹钟声音,并把完成次数加一,代码如下

* 播放器

```c#
//string music = Application.StartupPath.Substring(0, //Application.StartupPath.Length - 9) + "\\music\\alarm.wav";
SoundPlayer playeralarm = new SoundPlayer(@"F:\GitHub Repository\Management\music\alarm.wav");
SoundPlayer player = new SoundPlayer(@"F:\GitHub Repository\Management\music\rain.wav");
   
```

​	总共有两个播放器,一个播放雨声,一个播放闹钟声,最上面的music,是不想把文件路径写死,能够有相对路径,但是,,SoundPlayer好像不接受变量类型的参数,于是只能写死,如果有其他办法不写死文件路径,可以向我联系指正.

* 倒计时效果

```c#
        private void ToClock()
        {
            Attentiontime -= 1;
            int left = Attentiontime / 60;
            int right = Attentiontime % 60;
            string minute;
            string second;
            if (left < 10)
            {
                minute = "0" + left;
            
            else
            {
                minute = "" + left;
            }
            if (right < 10)
            {
                second = "0" + right;
            }
            else
            {
                second = "" + right;
            }

            TimeSet.Text = minute + ":" + second;
            if (Attentiontime == 0)
            {
                TimeSet.Text = "00:00";
                label1.Text = "已完成";
                string sql = string.Format(@"UPDATE tomato SET tdcounter=tdcounter+1 WHERE tdname='{0}'and uid={1}", tdname, uid);
                DBUtil db = new DBUtil();
                db.SqlQuery(sql);
                Shake();
                player.Stop();
                playeralarm.Play();
                timer1.Stop();
            }

        }
```

​	算法的逻辑是,通过秒数对60分别取余数和商,可以获得实时的分钟和秒,然后再将显示的label进行拼接即可

* 震动效果

```c#
        private void Shake()
        {
            int leftWidth = this.Left; //指定窗体左边值
            int topWidth = this.Top; //指定窗体上边值 
            for (int i = 0; i < 40; i++)
            {
                if (i % 2 == 0)
                {
                    this.Left = this.Left + 10;
                }
                else
                {
                    this.Left = this.Left - 10;
                }
                if (i % 2 == 0)
                {
                    this.Top = this.Top + 10;
                }
                else
                {
                    this.Top = this.Top - 10;
                }
                System.Threading.Thread.Sleep(30);//震动频率 
            }
            this.Left = leftWidth;//重设窗体初此左边值 
            this.Top = topWidth; //重设窗体初此上边值 
        }
```

​	借鉴了一下网上的代码
* 所有代码展示

```c#
        public string uid;
        private void button1_Click(object sender, EventArgs e)
        {
            player.Stop();
            playeralarm.Stop();
            this.Dispose();
        }
        SoundPlayer player = new SoundPlayer(@"F:\GitHub Repository\Management\music\rain.wav");
        private void TimeCounter_Load(object sender, EventArgs e)
        {
            timer1.Start();

            player.Play();
        }
        public int Attentiontime = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {

            ToClock();

        }
        public string tdname;
        private void Shake()
        {
            int leftWidth = this.Left; //指定窗体左边值
            int topWidth = this.Top; //指定窗体上边值 
            for (int i = 0; i < 40; i++)
            {
                if (i % 2 == 0)
                {
                    this.Left = this.Left + 10;
                }
                else
                {
                    this.Left = this.Left - 10;
                }
                if (i % 2 == 0)
                {
                    this.Top = this.Top + 10;
                }
                else
                {
                    this.Top = this.Top - 10;
                }
                System.Threading.Thread.Sleep(30);//震动频率 
            }
            this.Left = leftWidth;//重设窗体初此左边值 
            this.Top = topWidth; //重设窗体初此上边值 
        }
        string music = Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "\\music\\alarm.wav";
        SoundPlayer playeralarm = new SoundPlayer(@"F:\GitHub Repository\Management\music\alarm.wav");
        private void ToClock()
        {
            Attentiontime -= 1;
            int left = Attentiontime / 60;
            int right = Attentiontime % 60;
            string minute;
            string second;
            if (left < 10)
            {
                minute = "0" + left;
            }
            else
            {
                minute = "" + left;
            }
            if (right < 10)
            {
                second = "0" + right;
            }
            else
            {
                second = "" + right;
            }

            TimeSet.Text = minute + ":" + second;
            if (Attentiontime == 0)
            {
                TimeSet.Text = "00:00";
                label1.Text = "已完成";
                string sql = string.Format(@"UPDATE tomato SET tdcounter=tdcounter+1 WHERE tdname='{0}'and uid={1}", tdname, uid);
                DBUtil db = new DBUtil();
                db.SqlQuery(sql);
                Shake();
                player.Stop();
                playeralarm.Play();
                timer1.Stop();
            }

        }

```

​	当然,为了便于测试,我在窗体右上角加入了一个关闭按钮,如果考虑强制性的强制学习,或许可以将删除按钮给去掉,或者调整权限,无法删除.

#### 4.4 番茄统计

​	系统提供统计方法,并通过微软自带的charts方法显示饼图,用户可以清晰的观察到过去的代办完成时长.

![image-20211223200354862](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211223200354862.png)

```c#
        private void TomatoStatistics_Load(object sender, EventArgs e)
        {
            this.AutoScrollMinSize = new Size(ClientRectangle.Width, ClientRectangle.Height);
            string timelenth = "100000";
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.Font = new Font("宋体", 25);
            chartsdisplay(timelenth);

        }
```

​	对datagridview进行数据源赋值,然后调整其样式,进行一定程度的美化,其中的chartsdisplay函数,是对表格和图表的不同数据源进行修改,默认显示过去所有的番茄统计,于是写一个绝对大的值

```c#
        private void chartsdisplay(string timelenth) {
            DBUtil db = new DBUtil();
            string sql1 = string.Format(@"select  代办名称,代办时长*完成次数 as 总时长 from tmtsta where uid ={0} and DATEDIFF(day,创建时间,getdate())<={1}", uid, timelenth);
            DataSet ds1 = db.SqlSet(sql1);
            dataGridView1.DataSource = ds1.Tables[0];
            chart1.DataSource = ds1.Tables[0];
            chart1.Series["Series1"].XValueMember = "代办名称";
            chart1.Series["Series1"].YValueMembers = "总时长";
            chart1.Series["Series1"].IsValueShownAsLabel = true;
        }
```

​	其中的按年份,按周,按本日统计,则只需更改其中的时间天数即可,也就是timelenth

```c#
        private void button2_Click(object sender, EventArgs e)
        {
            string timelenth = "7";
            chartsdisplay(timelenth);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string timelenth = "1";
            chartsdisplay(timelenth);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string timelenth = "365";
            chartsdisplay(timelenth);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBUtil db = new DBUtil();
            string sql1 = string.Format(@"select * from tmtsta ");
            DataSet ds1 = db.SqlSet(sql1);
            dataGridView1.DataSource = ds1.Tables[0];
        }
```

### 5 账单_Bills

#### 5.1 添加账单

![image-20211223204911297](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211223204911297.png)

​	账单的添加大致与代办添加类似,也就不过多赘述,只是在下方贴出代码

```c#
       private bool check()
        {
            if (this.bname.Text == "")
            {
                MessageBox.Show("请输入消费名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.bname.Focus();
                return false;
            }
            else if (this.btype.Text == "") {
                MessageBox.Show("请输入消费类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.bname.Focus();
                return false;
            }
            else if (this.bvalue.Text == "")
            {
                MessageBox.Show("请输入消费金额！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.bname.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        public string uid;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string bnames = bname.Text.Trim();
                string btypes = btype.Text.Trim();
                string bvalues = bvalue.Text.Trim();
                string btime = DateTime.Now.ToString();
                //string uid ="1";
                DBUtil db = new DBUtil();
                string sql = string.Format(@"INSERT INTO bills(bname,btime,btype,uid,bvalue)
                    VALUES ('{0}','{1}','{2}','{3}','{4}');", bnames,btime,btypes,uid,bvalues);
                db.SqlQuery(sql);
                MessageBox.Show("添加成功");
            }
        }
```

#### 5.2 账单统计

​	同样的类似于番茄统计,也不再过多赘述,仍然在下方只贴出代码

```c#
        public string uid;

        private void BillsStatistics_Load(object sender, EventArgs e)
        {
            this.AutoScrollMinSize = new Size(ClientRectangle.Width, ClientRectangle.Height);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            string timelenth = "100000";
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.Font = new Font("宋体", 25);
            chartsdisplay(timelenth);

        }
        private void chartsdisplay(string timelenth)
        {

            DBUtil db = new DBUtil();
            string sql1 = string.Format(@"select 消费类型,sum(消费金额)as 消费总额 from billsta where  uid={0} and  DATEDIFF(day,创建时间,getdate())<= {1} group by 消费类型 ", uid, timelenth);
            DataSet ds1 = db.SqlSet(sql1);
            dataGridView1.DataSource = ds1.Tables[0];
            chart1.DataSource = ds1.Tables[0];
            chart1.Series["Series1"].XValueMember = "消费类型";
            chart1.Series["Series1"].YValueMembers = "消费总额";
            chart1.Series["Series1"].IsValueShownAsLabel = true;
        }
				private void button1_Click_1(object sender, EventArgs e)
        {
            string timelenth = "1";
            chartsdisplay(timelenth);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBUtil db = new DBUtil();
            string sql1 = string.Format(@"select * from billsta ");
            DataSet ds1 = db.SqlSet(sql1);
            dataGridView1.DataSource = ds1.Tables[0];
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string timelenth = "7";
            chartsdisplay(timelenth);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string timelenth = "365";
            chartsdisplay(timelenth);
        }
```

### 6 系统主题

​	系统主题的切换,难点主要是,要在一个窗体A上,新建一个窗体B,而B上点击的事件,要与A的属性绑定.具体到项目中,就是新建的System系统中按钮绑定原来的窗体DashBoard的颜色,于是,在这里采用了c#较为高级的技术,委托和事件

```c#
        private string rgbValue;
        public delegate void ChangeMainForm(Color c);
        public event ChangeMainForm change;

        private void btnColor4_Click(object sender, EventArgs e)
        {
            rgbValue = "102, 193, 140";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(102, 193, 140);
            change(c);
        }

        private void btnColor3_Click(object sender, EventArgs e)
        {
            rgbValue = "248,223,112";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(248, 223, 112);
            change(c);
        }

        private void SystemSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnColor1_Click(object sender, EventArgs e)
        {
            rgbValue = "143,178,201";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(143, 178, 201);
            change(c);
        }
        private void UpdateDefaultColor(string color)
        {
            string sql = string.Format("UPDATE userinfo set theme = '{0}'", color);
            DBUtil db = new DBUtil();
            db.SqlQuery(sql);
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            rgbValue = "147,213,220";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(147, 213, 220);
            change(c);
        }

        private void btnColor6_Click(object sender, EventArgs e)
        {
            rgbValue = "246,173,143";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(246, 173, 143);
            change(c);
        }

        private void btnColor5_Click(object sender, EventArgs e)
        {
            rgbValue = "242,230,206";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(242, 230, 206);
            change(c);
        }
```

​	同时,在DashBoard中,如此写道

```c#
            SystemSettings fs = new SystemSettings();
            fs.change += new SystemSettings.ChangeMainForm(ChangeColor);

            fmhpr.closeFrm(panelmain);
            fmhpr.openFrm(fs, panelmain);
```

​	这样就实现了最初的目的,值得一提的事,我也想过在番茄钟的显示处,使用这一项技术,但没有实现.如果有人解决这一问题,可以向我指正.

​	颜色主要是由rgb传入,参考了一个网站,上面有各种各样的漂亮的颜色,我把我使用的颜色标记在下面,以及参考的网址.

```c#
        /*
                菠萝紫  128,118,163
                星蓝 147,181,207
                麦秆黄 248,223,112
                淡藏花红 246,173,143
                清水蓝 147,213,220
                荔肉白 242,230,206
         */
	
```

参考网址:http://zhongguose.com/

### 7 用户管理

​	考虑到多人使用的用户管理,为管理员设置了用户管理功能,这一功能暂时只有超级管理员才能打开,可以在此面板中对管理员进行一些增删改查.

![image-20211223211242786](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211223211242786.png)

代码如下

```c#
        private void UserManager_Load(object sender, EventArgs e)
        {
            string sql = string.Format(@"select * from user_view");
            Search(sql);
        }
        private void Search(string sql) {
            DBUtil db = new DBUtil();
            DataSet ds1 = db.SqlSet(sql);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.Font = new Font("宋体", 25);
            dataGridView1.ForeColor = Color.FromArgb(248, 172, 89); 
            dataGridView1.DataSource = ds1.Tables[0];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccount.Clear();
            txtPassWord.Clear();
            txtid.Clear();
            txtUsername.Clear();
            txtTel.Clear();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string password = txtPassWord.Text;
            string username = txtUsername.Text;
            string telephone = txtTel.Text;
            int auth = this.cmbAuthority.SelectedIndex + 1;
            string sql = string.Format(@"insert into userinfo(account,password,username,telephone,authority,theme)values('{0}','{1}','{2}','{3}',{4},'248, 172, 89')", account, password, username, telephone, auth);
            DBUtil db = new DBUtil();
            db.SqlQuery(sql);
            MessageBox.Show("添加成功");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string password = txtPassWord.Text;
            string username = txtUsername.Text;
            string telephone = txtTel.Text;
            string uid = txtid.Text;
            int auth = this.cmbAuthority.SelectedIndex + 1;
            string sql = string.Format(@"update userinfo set account='{0}',password='{1}',username='{2}',telephone='{3}',authority={4},theme='248, 172, 89' where uid={5}", account, password, username, telephone, auth,uid);
            DBUtil db = new DBUtil();
            db.SqlQuery(sql);
            MessageBox.Show("修改成功");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uid = txtid.Text;
            string sql = string.Format(@"delete  from userinfo where uid={0}", uid);
            DBUtil db = new DBUtil();
            db.SqlQuery(sql);
            MessageBox.Show("删除成功");
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"select * from user_view");
            Search(sql);
        }
```

​	整体思路并不复杂,就是通过uid这一主键进行删改查,然后创建新用户,则不需要设置主键,因为数据库的设计处,为uid这一主键设置了自增长.

## 五 系统测试

### 1 登录

​	1.1**输入正确的用户名和密码**

![image-20211224090850252](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224090850252.png)

​	登录成功

![image-20211224090921775](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224090921775.png)

1.2 **输入错误的用户名和密码**

![image-20211224091048066](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091048066.png)

登录失败

![image-20211224091102643](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091102643.png)

1.3 **输入不全**

不输入用户名

![image-20211224091122616](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091122616.png)

不输入密码

![image-20211224091150451](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091150451.png)

**1.4 记住密码**

不记住密码的初始化

![image-20211224091310226](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091310226.png)

记住密码的初始化

![image-20211224091405246](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091405246.png)

1.5 **技术支持**

弹出qq对话框

![image-20211224091445679](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091445679.png)

### 2 仪表盘

初始化

![image-20211224091532755](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091532755.png)

侧边栏折叠

![image-20211224091546697](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091546697.png)

侧边栏展开

![image-20211224091602774](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091602774.png)

打开主页

![image-20211224091630828](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091630828.png)

### 3 番茄钟

打开番茄钟页面

### 
![image-20211224091647290](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091647290.png)

添加番茄钟

![image-20211224091721403](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091721403.png)

如果缺失值,点击添加(只测一例)

![image-20211224091740165](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091740165.png)

点击清空

![image-20211224091814637](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091814637.png)

点击添加

![image-20211224091855551](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091855551.png)

添加成功,在番茄钟列表中显示成功

![image-20211224091914771](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091914771.png)

测试触发器

![image-20211224091952091](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224091952091.png)

可以看到,不能创建同名的代办

点击开始番茄专注

![image-20211224092045506](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224092045506.png)

自动倒计时并播放音乐(完成后暂不测试,时间过长)

番茄统计测试

![image-20211224092137391](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224092137391.png)

今日统计

![image-20211224092233584](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224092233584.png)

本周统计(这里数据量过少)

![image-20211224092246503](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224092246503.png)

年度统计

![image-20211224092311033](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224092311033.png)

详细统计

![image-20211224092319557](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224092319557.png)

### 4 账单

添加消费

![image-20211224092535815](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224092535815.png)

如果消费金额数据类型错误

![image-20211224092605199](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224092605199.png)

账单统计

![image-20211224092753895](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224092753895.png)

类似番茄统计

### 5 系统主题

更改主题

![image-20211224092840692](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224092840692.png)

重新登录后,系统主题,仍然是绿色

![image-20211224092905688](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224092905688.png)

### 6 用户管理

添加用户

![image-20211224093023436](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224093023436.png)

刷新后查看添加成功

![image-20211224093045603](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224093045603.png)

更改用户信息

![image-20211224093140581](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224093140581.png)

更改成功

![image-20211224093238343](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224093238343.png)

删除用户

![image-20211224093313200](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224093313200.png)

删除成功

![image-20211224093355588](/Users/tangyufeng/Library/Application Support/typora-user-images/image-20211224093355588.png)

## 六 自我评述

​	在项目开发过程中,也曾经遇到一些困难,总结如下;

### 1 c#

​	c#的问题较多,由于之前没有系统性的学习过c#,加上在国内的论坛网站上,c#winform都是一项较为过时的技术,所以,面临一些前端设计的问题时,出现了最大的困难

* 窗体嵌套

​	对于窗体嵌套,之前按照自己的写法,总是由于窗体的私密级别而出现各种错误,导致传入参数失败,而后请教老师解决

* 委托事件

​	对于更改系统颜色的操作,需要进行事件的委托,涉及到一些c#的高级操作,对于这部分内容,我的掌握也不是很深,只能说可以照猫画虎

* 番茄钟的显示问题

​	我想要做成的效果是,点击添加按钮之后,立马可以刷新番茄列表,而不是再次点击侧边栏的番茄钟,这部分的内在逻辑肯定有了问题,经过尝试,我的委托应该没有写错,因为我尝试着写一个refresh按键,但是也无法重置

* 权限控制不完善

​	对于一些超级管理员,管理员,用户的权限划分问题,没有做好详细的规划,但是已经完成了最重要的authority传入,已经实现了authority传入到每一个窗体,所以,如需添加这部分的权限控制功能,只需要进行一个简单的if判断即可

* 控件属性了解不足

​	对于datagridview一些属性了解不足,所以导致不能自己进行自定义设置,致使美化度不足

### 2 数据库设计

​	对于数据库,虽然在使用的过程中,并没有遇到过大的困难,但在完成项目之后,仍然发现数据库设计上的缺失,如果后面有时间,会针对这一部分进行修改

* 番茄表的设置问题

​	在番茄表的设计中,有创建时间这一个属性,但是在统计中,有按每周进行统计,那么如何按照每周进行统计呢?理论上应该是再设计一个表,记录每一个番茄钟完成的时间,然后把规定时间内的完成次数聚合加总

* 约束问题

​	在许多表的设计中,对于表的约束性不够强,例如,番茄钟的代办类型,可以定死为in ('顺时针','逆时针'),但是当时创建过程中,由于是一个人完成前后端所有项目,导致细节完善不足.

* 安全性问题

​	对于sql的问题,在登录处,没有做好安全性问题,在这里,应该通过存储过程设计登录功能,进而防止用户进行sql注入

​	例如 where password='123456' or 1=1

## 七 课程学习体会

​	数据库的课程使我获益良多,第一次完成了一个前后端的整体项目,学会了sql的基本语句,但是总得来说,在不断的进行项目搭建过程中,我也发现了winform的一些局限性,例如,只能在Windows使用,潜在用户少(大多数用户不愿意下载这么大的软件),而且设计UI整体较为陈旧,所以,我经过了解,发现现在主流的网站开发是应用Java的Springboot框架+vue,可以发现,在c#的书写过程中,我会写很多内置的sql语句到程序中,但在Springboot中,更多采用前后端分离,只需要穿出json数据即可.所以,在之后的学习中,可能会更换语言为生态更好的java.

​	对于整体的数据库课程设计,我认为是安排的较好的,首先讲了理论上的一些关系运算,还有就是对于sql语句的应用,数据库里触发器,存储过程,关系约束等等,,但我认为,可以增加一些更加底层的原理内容,如何优化数据库的设计,如何尽可能减少数据安全意外等等

​	前端语言,我个人更加推荐使用java,因为winform在现在来说比较落后,但可能是老师考虑到一些人没有开发基础,所以选择c#也正常.

<<<<<<< HEAD
​	最后,非常感谢老师这学期的辛勤付出,对于我的一些疑问,,也是和蔼的回答,同时,老师对于技术的探索,也让我感慨,所有的代码必然自己亲自测试,有什么感兴趣的点,也会认真的观看开发文档,值得学习.希望老师可以给出数据库后续的学习路线,给感兴趣的同学指引学习方向.
=======
​	最后,非常感谢老师这学期的辛勤付出,对于我的一些疑问,,也是和蔼的回答,同时,老师对于技术的探索,也让我感慨,所有的代码必然自己亲自测试,有什么感兴趣的点,也会认真的观看开发文档,值得学习.希望老师可以给出数据库后续的学习路线,给感兴趣的同学指引学习方向.
>>>>>>> 4033cef223a5af04247ec1ffe312ab3e85d9ecbe
