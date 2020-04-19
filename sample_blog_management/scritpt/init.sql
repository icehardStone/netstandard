create database blog;
create database files;
create user blog identified by 'hu123456';
drop user blog;

grant ALL on  blog.* to blog;
grant all on files.* to blog;

select user,host from mysql.user;
