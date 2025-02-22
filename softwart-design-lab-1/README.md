## Принципи програмування у коді
### 1. DRY (Don't Repeat Yourself)

У коді уникається дублювання шляхом інкапсуляції в повторно використовуваних методах і класах наприклад.
- Клас InventoryManager централізує операції управління запасами на складі, запобігаючи подальшим дублюванням.
- І загалом в коді мінімізовано дублювання коду, але в межах розумного щоб не порушувати AHA (Avoid Hasty Abstractions).
(посилання на клас InventoryManager [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/InventoryManager.cs#L1-L45))

### 2. KISS (Keep It Simple Stupid)

Загалом проста реалізація у методах і наявність інтерфейсів що гарантують дотримання простого контракту, немає завеликих методів зі складною логікою.
- Наприклад інтерфейси IProduct, IMoney, IReporting, IWarehouse допомагають дотримуватися простої спланованої логіки.
- Клас PercentageReduction використовує просту арифметику для підрахунку плану зменшення ціни у відсотках як і метод Substract() в класі Money.
(посилання на клас інтерфейси і на метод: IMoney [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Interfaces/IMoney.cs#L1-L12), IProduct [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Interfaces/IProduct.cs#L1-L9), IReporting [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Interfaces/IReporting.cs#L1-L9), IWarehouse [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Interfaces/IWarehouse.cs#L1-L9), Substract() [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Money.cs#L56-L66))

 ### 3. SRP (Single Responsibility Principle)

Кожен клас має єдину відповідність.
- Наприклад класи InventoryManager, Warehouse, Money, Product, Reporting відповідають єдиному функціоналу, InventoryManager тільки створений щоб обєднувати дії в Reporting і Warehouse, в один об'єкт керування.
(посилання на відповідні класи: Inventory Manager [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/InventoryManager.cs), Reporting [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Reporting.cs), Warehouse [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Warehouse.cs), Money [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Money.cs), Product [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Product.cs))

### 4. OCP (Open/Closed Principle)

Тобто класи мають бути відкриті до розширення та закриті для модифікації.
- Ми можемо додавати нову реалізацію для знижок через інтерфейс IPriceReduction без зміни класів з вже готовим планом знижок реалізованим у класах PercentageReduction і StraigtReduction.
(посилання на інтерфейси і класи: IPriceReduction [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Interfaces/IPriceReduction.cs), PercentageReduction [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/PriceReduction/PercentageReduction.cs), StraightReduction [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/PriceReduction/StraightReduction.cs))

### 5. LSP (Liskov Substitution Principle)

Підкласи повинні замінювати базові класи без заміни поведінки.
- Наприклад будь-який клас який буде реалізувати інтерфейс IPriceReduction у класі Product у методі ReducePrice().
- (посилання на інтерфейс, клас і метод: IPriceReduction [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Interfaces/IPriceReduction.cs), Product і ReducePrice() [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Product.cs#L17-21)

### 6. ISP (Interface Segregation Principle)

Програмні сутності не повинні залежати від методів які вони не використовують
- Всі класи які використовують інтерфейси у коді не насідують жодних зайвих методів, тобто всі методи є необхідні для реалізації.

### 7. DIP (Dependency Inversion Principle)

Модулі вищого рівня не повинні напряму залежати від модулів нижчого рівня.
- Для прикладу клас Product залежить від абстракції реалізованої через інтерфейс IMoney, а не прив'язаний до класу Money напряму.
(посилання на класи і інтерфейс: Money [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Money.cs), IMoney [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Interfaces/IMoney.cs), Product [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Product.cs#L8) і [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Product.cs#L10))

### 8.  Composition Over Inheritance

Надавити перевагу композиції замість глибокої ієрархії наслідувань.
- InventoryManager використовує IReporting і IWarehouse замість наслідування.
- Product делегує зниження ціни через IPriceReduction, уникаючи жорсткого зв’язку.
(посилання на класи і інтерфейси: IWarehouse [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Interfaces/IWarehouse.cs), IReporting [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Interfaces/IReporting.cs), InventoryManager [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/InventoryManager.cs#L8-L9), Product з IPriceReduction [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Product.cs#L17))

### 9. Program to Interfaces not Implementations

Програмування через інтерфейс а не через реалізації, що надає гнучкість завдяки абстракції.
- InventoryManager залежить від IWarehouse та IReporting, що дозволяє легко змінювати їх реалізації.
- Product працює через IMoney, що забезпечує майбутню підтримку різних валют.

### 10. Fast Fail

Швидке виявлення помилок для запобігання несподіваних помилок.
- Майже в кожному класі наявні перевірки з створенням виключень у разі неправильних даних, щоб встановити помилку.
- Наприклад, PercentageReduction перевіряє, що відсоток знижки знаходиться у межах 0-100 перед застосуванням.
- Перевірка аргументів запобігає некоректним станам (Product.cs, Warehouse.cs).
(посилання на класи: PercentageReduction [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/PriceReduction/PercentageReduction.cs#L11-L12), Product [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Product.cs#L19), Warehouse [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Warehouse.cs#L16-17) і [тут](https://github.com/Hokaigo/Software-design/blob/main/softwart-design-lab-1/ClassLibrary/Warehouse.cs#L27-L29)
