# Текстовое описание решения задачи итоговой проверочной работы за I четверть

**Задача:** Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**

	["hello", "2", "world", ":-)"] -> ["2", ":-)"]
	["1234", "1567", "-2", "computer science"] -> ["-2"]
	["Russia", "Denmark", "Kazan"] -> []

## Описание

При инициализации программы задается пустая строковая переменная `tmp`, и строковая переменная `separator`, которая будет использоваться для разделения строки на выходной массив. Переменной `separator` должна быть присвоена последовательность символов, которая не должна встречаться во входных данных. По-умолчанию присвоено значение перевода строки `\n`, т. к. пользователь без дополнительных ухищрений последовательность перевода строки с клавиатуры не введет. 

Перед вводом массива пользователь задает его размерность. Ввод значений массива `in_array` организован с помощью цикла и осуществляется пользователем с клавиатуры. Входные данные не проверяются на корректность. Если предполагается наличие в поступаемых данных последовательности символов, указанной в переменной `separator`, то желательно в блоке инициализации программы изменить значение переменной.

После выхода из цикла ввода сбрасывается флажок `flag` наличия строк длиной менее 4 символов (меньше либо равно 3). В новом цикле перебираются все элементы введенного массива. Если длина массива менее 4 символов, то при поднятом `flag` к переменной `tmp` добавляется `separator`, а дальше вне зависимости от состояния флажка текущее значение массива складывается с переменной `tmp` и поднимается флажок `flag`, обозначающий, что в строке `tmp` уже были внесены значения.

Таким образом, после выхода из цикла, в строке `tmp` хранятся все значения входного массива длиной менее 4 символов разделенны последовательностью `separator`. Выходной массив `out_array` получается после использования стандартного для строк метода Split, примененной к строке `tmp`. 

Полученный массив выводится в консоль. Программа завершается.

## Блок-схема

Блок-схема доступна по [ссылке](flowchart.md).

## Исходный код C#

Исходный код доступен по [ссылке](task/Program.cs).