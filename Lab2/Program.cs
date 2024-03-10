using Lab2;

/* Задание: Адаптеры H (география, туризм, ...) */

RussianHotel russianHotel = new();

russianHotel
    .CheckIn(new NativeRussian())
    .CheckIn(new AmericanToRussianAdapter(new American()))
    .CheckIn(new NativeRussian())
    .CheckIn(new NativeRussian())
    .CheckIn(new AmericanToRussianAdapter(new American()))
    .CheckIn(new NativeRussian());

russianHotel.SwearAll();