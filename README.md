# Clean Architecture

## Project Structure 

MyApp
│
├── Domain
│   ├── Entities
│   │   └── Product.cs
│   ├── ValueObjects
│   └── Interfaces
│       └── IProductRepository.cs
│
├── Application
│   ├── DTOs
│   │   └── ProductDto.cs
│   ├── Services
│   │   ├── IProductService.cs
│   │   └── ProductService.cs
│   └── Mapping
│       └── ProductMapper.cs (optional)
│
├── Infrastructure
│   ├── Persistence
│   │   ├── AppDbContext.cs
|   |   └─- Migration
│   └── Repositories
│       └── ProductRepository.cs
│
└── WebApi
    ├── Controllers
    │   └── ProductsController.cs
    └── Program.cs

