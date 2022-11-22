create proc add_customer
@Id int,
@cust_name varchar(250),
@card_no varchar(20),
@card_loc varchar(50),
@card_date date,
@conservatism varchar(20),
@city varchar(20),
@squar varchar(20),
@street varchar(20),
@tel varchar(50),
@phone varchar(20),
@email varchar(40),
@imag image,
@note varchar(300),
@aucioneer varchar(250),
@agent varchar(250),
@cust_type_id int
as 

insert into customer
( 
Id,cust_name,card_no,card_loc,card_date
,conservatism,city,squar,street,tel,phone,
email,imag,note,auctioneer,agent,cust_type_id
)
values
(
    @Id, @cust_name,@card_no,@card_loc,@card_date
	,@conservatism,@city,@squar,@street,@tel,@phone
	,@email,@imag,@note,@aucioneer,@agent,@cust_type_id
)