«Інтернет магазин з продажу комп’ютерних ігор»

Сутність Author
Ця сутність представляє собою сукупність інформації про певну автора гри. Автор має відповідні атрибути:
●	AuthorId 
●	Name
●	PlatformCut

Бізнес-правила. Відносно сутності автор діють такі бізнес-правила:
●	AuthorId є унікальним номером, який закріплено за відповідним автором.
●	AuthorId інкрементується автоматично із кожним додаванням нового автора та не може бути порожнім
●	PlatformCut не може бути порожнім

Сутність Basket
Представляє козину користувача.

Характеризується такими атрибутами:
●	UserId
●	GameId

Зв’язки:
●	Зв’язок UserId вказує на користувача який обрав гру до корзини.
●	Зв’язок GameId вказує на гру яку обрав користувач.

Бізнес-правила. Відносно сутності діють такі правила:
●	UserId не може бути порожнім
●	GameId не може бути порожнім

Сутність Game
Представляє собою гру яку можна придбати.

Атрибути:
●	GameId
●	AuthorId
●	Name
●	Genre 
●	Release 
●	Cost

Зв’язки:
●	Зв’язок AuthorId вказує на автора гри.

Бізнес-правила:
●	GameId є унікальним серед інших ігор.
●	GameId інкрементується автоматично із кожним додаванням
●	AuthorId не може бути порожнім
●	Release не може бути порожнім
●	Cost не може бути порожнім

Сутність Review
Представляє коментар до гри.

Атрибути:
●	ReviewId
●	UserId 
●	GameId 
●	ReviewText 
●	Likes
●	Dislikes
●	Date

Зв’язки:
●	UserId вказує на користувача який залишив цей коментар
●	GameId вказує на гру яку прокоментували

 Бізнес-правила:
●	ReviewId є унікальним серед інших коментарів
●	ReviewId інкрементується автоматично із кожним додаванням
●	Likes не може бути порожнім
●	Dislikes не може бути порожнім
●	Date не може бути порожнім

Сутність User
Представляє собою клієнта

Атрибути:
●	UserId
●	Nickname
●	Email

Бізнес-правила:
●	UserId є унікальним серед інших користувачів
●	Id інкрементується автоматично із кожним додаванням


ТЕХНОЛОГІЇ
.NET
ADO NET
Entity Framework
MsSQL
