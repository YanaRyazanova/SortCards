# SortCards
Сортировщик колод карт.
Приведена стандартная реализация интерфейсов ICardDeck и IDeck.Возможна другая реализация.
Чтобы воспользоваться необходимо создать экземпляр класса StandartCardsDeck с реализацией StandartDeck.
API:
 - Создать именованную колоду карт (колода создаётся упорядоченной) - CreateCardDeck(TDeck newDeck);
 - Удалить именованную колоду -  DeleteCardDeck(string deletedDeck);
 - Получить список названий колод - GetNamesDecks()
 - Перетасовать колоду - ShaffleDeck(string nameDeck, ShuffleAlgo algo) (реализована простая перетасовка алгоритмом Фишшера
 - Получить колоду по имени (в её текущем упорядоченном/перетасованном состоянии) - GetDeckByName(string name)

