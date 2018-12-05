/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: KitchenEquipment
------------------------------------------------------------*/
CREATE TABLE KitchenEquipment(
	Id            INT IDENTITY (1,1) NOT NULL ,
	Quantity      INT  NOT NULL ,
	Type          VARCHAR (50) NOT NULL ,
	WashingTime   INT  NOT NULL  ,
	CONSTRAINT KitchenEquipment_PK PRIMARY KEY (Id)
);


/*------------------------------------------------------------
-- Table: IngredientType
------------------------------------------------------------*/
CREATE TABLE IngredientType(
	Id               INT IDENTITY (1,1) NOT NULL ,
	IngredientType   VARCHAR (50) NOT NULL  ,
	CONSTRAINT IngredientType_PK PRIMARY KEY (Id)
);


/*------------------------------------------------------------
-- Table: Ingredient
------------------------------------------------------------*/
CREATE TABLE Ingredient(
	Id                  INT IDENTITY (1,1) NOT NULL ,
	Ingredient          VARCHAR (50) NOT NULL ,
	Id_IngredientType   INT  NOT NULL  ,
	CONSTRAINT Ingredient_PK PRIMARY KEY (Id)

	,CONSTRAINT Ingredient_IngredientType_FK FOREIGN KEY (Id_IngredientType) REFERENCES IngredientType(Id)
);


/*------------------------------------------------------------
-- Table: RecipeType
------------------------------------------------------------*/
CREATE TABLE RecipeType(
	Id           INT IDENTITY (1,1) NOT NULL ,
	RecipeType   VARCHAR (50) NOT NULL  ,
	CONSTRAINT RecipeType_PK PRIMARY KEY (Id)
);


/*------------------------------------------------------------
-- Table: Recipe
------------------------------------------------------------*/
CREATE TABLE Recipe(
	Id                INT IDENTITY (1,1) NOT NULL ,
	Recipe            VARCHAR (50) NOT NULL ,
	QuantityCreated   INT  NOT NULL ,
	Id_RecipeType     INT  NOT NULL  ,
	CONSTRAINT Recipe_PK PRIMARY KEY (Id)

	,CONSTRAINT Recipe_RecipeType_FK FOREIGN KEY (Id_RecipeType) REFERENCES RecipeType(Id)
);


/*------------------------------------------------------------
-- Table: Step
------------------------------------------------------------*/
CREATE TABLE Step(
	Id                    INT IDENTITY (1,1) NOT NULL ,
	StepNumber            INT  NOT NULL ,
	StepDescription       TEXT  NOT NULL ,
	Duration              INT  NOT NULL ,
	Id_Recipe             INT  NOT NULL ,
	Id_KitchenEquipment   INT    ,
	CONSTRAINT Step_PK PRIMARY KEY (Id)

	,CONSTRAINT Step_Recipe_FK FOREIGN KEY (Id_Recipe) REFERENCES Recipe(Id)
	,CONSTRAINT Step_KitchenEquipment0_FK FOREIGN KEY (Id_KitchenEquipment) REFERENCES KitchenEquipment(Id)
);


/*------------------------------------------------------------
-- Table: StockType
------------------------------------------------------------*/
CREATE TABLE StockType(
	Id          INT IDENTITY (1,1) NOT NULL ,
	StockType   VARCHAR (50) NOT NULL  ,
	CONSTRAINT StockType_PK PRIMARY KEY (Id)
);


/*------------------------------------------------------------
-- Table: StockingZone
------------------------------------------------------------*/
CREATE TABLE StockingZone(
	Id              INT IDENTITY (1,1) NOT NULL ,
	StockingDate    DATETIME NOT NULL ,
	Quantity        INT  NOT NULL ,
	Id_Ingredient   INT  NOT NULL ,
	Id_StockType    INT  NOT NULL  ,
	CONSTRAINT StockingZone_PK PRIMARY KEY (Id)

	,CONSTRAINT StockingZone_Ingredient_FK FOREIGN KEY (Id_Ingredient) REFERENCES Ingredient(Id)
	,CONSTRAINT StockingZone_StockType0_FK FOREIGN KEY (Id_StockType) REFERENCES StockType(Id)
);


/*------------------------------------------------------------
-- Table: EquipmentType
------------------------------------------------------------*/
CREATE TABLE EquipmentType(
	Id              INT IDENTITY (1,1) NOT NULL ,
	EquipmentType   VARCHAR (50) NOT NULL  ,
	CONSTRAINT EquipmentType_PK PRIMARY KEY (Id)
);


/*------------------------------------------------------------
-- Table: Equipment
------------------------------------------------------------*/
CREATE TABLE Equipment(
	Id                 INT IDENTITY (1,1) NOT NULL ,
	Type               VARCHAR (50) NOT NULL ,
	Quantity           INT  NOT NULL ,
	Id_EquipmentType   INT  NOT NULL  ,
	CONSTRAINT Equipment_PK PRIMARY KEY (Id)

	,CONSTRAINT Equipment_EquipmentType_FK FOREIGN KEY (Id_EquipmentType) REFERENCES EquipmentType(Id)
);


/*------------------------------------------------------------
-- Table: StepIngredient
------------------------------------------------------------*/
CREATE TABLE StepIngredient(
	Id        INT  NOT NULL ,
	Id_Step   INT  NOT NULL  ,
	CONSTRAINT StepIngredient_PK PRIMARY KEY (Id,Id_Step)

	,CONSTRAINT StepIngredient_Ingredient_FK FOREIGN KEY (Id) REFERENCES Ingredient(Id)
	,CONSTRAINT StepIngredient_Step0_FK FOREIGN KEY (Id_Step) REFERENCES Step(Id)
);



