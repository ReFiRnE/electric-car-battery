USE [Car Battery];

CREATE TABLE Customer (
	customerID int not null identity,
	name varchar(255) not null
	PRIMARY KEY (customerID)
);

CREATE TABLE BatteryManufacturer (
	manufacturerID int not null identity,
	name varchar(255) not null,
	PRIMARY KEY (manufacturerID)
);

CREATE TABLE BatteryStation (
	stationID int not null identity,
	name varchar(255) not null,
	timeOpen date not null,
	timeClose date not null,
	PRIMARY KEY (stationID)
);

CREATE TABLE Car (
	carID int not null identity,
	customerID int not null,
	range float not null,
	capacity float not null,
	PRIMARY KEY (carID),
	FOREIGN KEY (customerID) REFERENCES Customer (customerID)
);

CREATE TABLE BatteryModel (
	modelID int not null identity,
	model varchar(255) not null,
	capacity float not null,
	type varchar(255) not null,
	manufacturerID int not null,
	PRIMARY KEY (modelID),
	FOREIGN KEY (manufacturerID) REFERENCES BatteryManufacturer (manufacturerID)
);

CREATE TABLE BatteryItem (
	batteryID int not null identity,
	modelID int not null,
	PRIMARY KEY (batteryID),
	FOREIGN KEY (modelID) REFERENCES BatteryModel(modelID)
);

CREATE TABLE BatteryLocation (
	locationID int not null identity,
	stationID int not null,
	batteryID int not null,
	PRIMARY KEY (locationID),
	FOREIGN KEY (stationID) REFERENCES BatteryStation(stationID),
	FOREIGN KEY (batteryID) REFERENCES BatteryItem (batteryID)
);

CREATE TABLE BatteryCarHistory (
	historyID int not null identity,
	carID int not null,
	batteryID int not null,
	dateTaken date not null,
	dateReturned date not null,
	PRIMARY KEY (historyID),
	FOREIGN KEY (carID) REFERENCES Car (carID),
	FOREIGN KEY (batteryID) REFERENCES BatteryItem (batteryID)
);

CREATE TABLE Booking 
(
	bookingID int not null identity,
	date date not null,
	batteryID int not null,
	carID int not null,
	PRIMARY KEY (bookingID),
	FOREIGN KEY (batteryID) REFERENCES BatteryItem (batteryID),
	FOREIGN KEY (carID) REFERENCES Car (carID)
);
