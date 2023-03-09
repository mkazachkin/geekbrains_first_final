# Бок-схема решения задачи итоговой проверочной работы за I четверть

**Задача:** Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**

	["hello", "2", "world", ":-)"] -> ["2", ":-)"]
	["1234", "1567", "-2", "computer science"] -> ["-2"]
	["Russia", "Denmark", "Kazan"] -> []

## Блок-схема
```mermaid
flowchart TB
	node_000(("START"))
	node_010["separator = #quot;#92;n#quot;\ntmp = #quot;#quot;"]
	node_020[/"Input:
	length"/]
	node_025["i = 0"]
	node_030{"i < length"}
	node_040[/"in_array[i]"/]
	node_050["i++"]
	node_060["flag = false\ni = 0"]
	node_070{"i < length"}
	node_080{"in_array[i].length < 4"}
	node_090{"flag"}
	node_100["tmp += separator"]
	node_110["tmp += in_array[i]\nflag = true"]
	node_120["i++"]
	node_130["out_array = tmp.Split(separator)"]
	node_140[/"Output:
	out_array"/]
	node_150(("END"))

	node_000-->node_010
	node_010-->node_020
	node_020-->node_025
	node_025-->node_030
	node_030--yes-->node_040
	node_030--no-->node_060
	node_040-->node_050
	node_050-->node_030
	node_060-->node_070
	node_070--yes-->node_080
	node_070--no-->node_130
	node_080--yes-->node_090
	node_080--no-->node_120
	node_090--yes-->node_100
	node_090--no-->node_110
	node_100-->node_110
	node_110-->node_120
	node_120-->node_070
	node_130---->node_140
	node_140-->node_150
```

## Описание

Текстовое описание алгоритма доступно по [ссылке](README.md).

## Исходный код C#

Исходный код доступен по [ссылке](task/Program.cs).