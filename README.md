# Lilly's Catering MVC project

This is an administration website intended for the staff at Lilly's Catering.
This website is a MVC web application built in ASP.NET 7 Core using Entity Framewore Core.

On this website the staff can handle CRUD functionality for menus, dishes and orders.

Two API's have been scaffolded through Entity Framework:

Dishes:
```
| Method         | Endpoint             | 	        Description		       |
| ------------- |----------------------| --------------------------------------------- |
| GET           | /api/dishapi     | Get all dishes in the database   |
| GET           | /api/dishapi/id | Get a specific dish in the database	       |
| POST 		| /api/dishapi    | Create a new dish	               |
| PUT 		| /api/dishapi/id| Update a dish            |
| DELETE 	| /api/dishapi/id| Delete a dish              |
```

Orders:
```
| Method         | Endpoint               | 	       Description		       |
| ------------- |------------------------| --------------------------------------------|
| GET           | /api/bookingapi        | Get all the booking in the database |
| GET           | /api/bookingapi/id    | Get a specific booking in the database	      |
| POST 		| /api/bookingapi        |Create a new booking		       |
| PUT 		| /api/bookingapi/id    | Update a booking        |
| DELETE 	| /api/bookingapi/id     | Delete a booking  	       |
```

The API receives and returns JSON data with the following structure: 


{ "_id": "1", "name": "Jane Doe", "phoneNo": "+46 00 000 00 00", "order": "Italian menu - 12 people", "address": "Fake street 10", "date": "2023-04-01T00:00:00" }

![Screenshot 2023-03-19 at 20 55 04](https://user-images.githubusercontent.com/78862890/226205500-81425837-7ed5-432a-9c85-d2994595d01d.png)

