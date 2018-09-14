# Introduction
C# code to understand difference between Factory and Strategy Design Patterns.

# The Code
A dotnet core console application.

# Details

1. Dummy Product list is fetched from the (dummy) backend.
2. Product list is scrubbed using Strategy Pattern. Two strategies are implemented i.e. SortByID and SortByDisplayOrder.
3. Product list is printed (published) using Factory Pattern. Two different output methods are implemented.


### Data: Fetch the data from a service

| # |File Name | Description 
| ---| ---  | ---           
| 1 | Data\DataModel.cs | A simple class containing few properties. Depicts a Product .
| 2 | Data\DataService.cs | Depiction of a service layer. Fetches list of Products.

### Strategies: Two ways to sort the list
| # |File Name | Description 
| ---| ---  | ---           
| 1 | Strategies\SortStrategy.cs | Abstract class with one method SortProducts(). Sets contract for child strategy classes.
| 2 | Strategies\SortStrategyByDisplayOrder.cs and Strategies\SortStrategyByID.cs  | Concrete implementation of SortStrategy .
| 3 | Strategies\ScrubProduct.cs| Receives the abstract type and runs its concrete implementation.


### Factory: Two ways to publish the data
| # |File Name | Description 
| ---| ---  | ---           
| 1 | Factory\IFileOutput.cs| An interface. Has one method called GenerateOutput.
| 2 | Factory\FlatFileOutput.cs and Factory\ExcelFileOutput.cs| Two different implementations of IFileOutput.
| 3 | Factory\FileOutputFactory.cs| Factory class.

### Root: Let's call our code 
| # |File Name | Description 
| ---| ---  | ---           
| 1 | ProductManager.cs| Calls data service and publishes data.
| 2 | Program.cs| Main entry point.




