Проекты, папки и что в них:

	Папка HelperLibrarys - все дополнительные проекты, которые нужны для работы всего:
		ApplicationContextDB - тут хранятся контексты базы данных (нужны для подключения к бд), в название класса указано название бд, к которому подключение прописано.
		DTO - тут хранятся все модели и сущности (сущности, чтобы брать данные из бд, а модели, шо б перекидывать их между сервисами), 
			внутри проекта есть ConvertExtensions.cs, это класс расширения для класса Convert, в котором прописано преобразования одних типов данных в других.
		EntitiesRepositories - проект, в котором лежат классы, которые достают/кладут из/в бд данные (в название указано с какой бд работает класс).

	Папка Services - внутри все проекты, которые являются микросервисами:
		В каждом сервисе есть котроллер или несколько, в которых прописаны endpoins (то куда идёт запрос и где он обрабатывается).
		Во всех Program.cs прописаны services.Add... - это внедренние зависимостей, т. е. зависимости куда нужно внутри сервиса пробрасываются (у нас тут через конструктор происходит).
		
		AuthorizationService - сервис, в котором происходит авторизация, по факту просто кидается моделька с пароль и логином, проверяется есть такой пользователь в бд, 
			если есть то отправляется его логин и id назад, если нет, то null.
		HomeStorageService - сервис, который работает с данными о жилье, в том числе и резервированием. По названием методов, в контроллере будет, думаю, понятно, шо они делают,
			post метод добавляет, put метод обновляет данные.
		ReviewService - сервис, который работает с отзывами достаёт их и добавляет новые.
		GeneralService - сервис, который работыет с другими, то есть из него во все остальные сервисы отправляются запросы, контроллеры работают с сервисами, которые в названии указаны.

	Проект RenHomeApp - наш клиент, визуальная часть и всё такое.
		AuthorizationForm - форма для авторизации.
		RentalHomeForm - форма где находятся все варианты жилья.
			Тут есть небольшая особенность, в этой форме основной графический элемент FlowLayoutPanel, по сути, контейнер для других элементов, в програмном коде 
			в методе CreatePanelsWithInfo создаются элементы panel, в которых отрисовывается нужная нам информация о квартире.
		InfoHomeForm - форма с подробной информацией о квартире выбранной.
			Тут подобная штука как и в RentalHomeForm, но мы пихаем в этот контейнер textBox с заблоченной возможностью изменяеть там текст.
		NewReviewForm - форма для оставления нового комментария.
		ReservationForm - форма для бронирования.

		В папке Services находятся классы, в которых прописана отправка запросов на сервис GeneralService, который в свою очередь отправляет запросы остальным сервисам
			и переправляет нам ответы.
		
Запуск всего этого добра:

	В решении в папке Services нужно перейти в AuthorizationService, HomeStorageService, ReviewService и в каждом сервисе будет файл appsettings.json, если его раскрыть по стрелочке
	то раскроется файл appsettings.Development.json, открыв этот файл можно увидеть строку, пример: "Server=[BRUNGILDA\\SQLEXPRESS];Database=Home;Integrated Security=True;TrustServerCertificate=True;"
	в ней нужно переделать часть, которая выделена [] скобками. Туда нужно вставить адрес сервера своего MS SQL Server.
	Ту же операцию нужно провести для appsettings.json, который лежит в проекте TestApp.

	Далее нужно запустить проект TestApp, после чего создадут в MS SQL нужные нам бд.

	После чего можно запускать всё остальное, а именно:
		Все сервисы запуска в режиме без отладки, а RenHomeApp, можно и с отладкой, а можно и без, тут похуй.

	PS: Чтобы перейти на подробную информацию о жилье нужно нажать дважды на панельку с этой квартирой.
