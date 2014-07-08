####Условие задачи:

Два отрезка на плоскости заданы координатами своих концов. Определить, имеют ли эти отрезки общие точки. Необходимо рассмотреть различные случаи взаимной ориентации отрезков: на одной прямой, на параллельных прямых, на пересекающихся прямых.

Программа работает на языке C#. На вводе задаются координаты концов двух отрезков на плоскости. Далее, находим уравнения прямых заданных отрезков. Уравнение прямой имеет вид: y=kx+b, где k-угловой коэффициент, b-свободный член уравнения.
Найдем угловой коэффициент для каждой прямой по формуле: k = (x1-x0)/(y1-y0), где x0,y0, х1, у1 - координаты точки, принадлежащей этой прямой.

Выразим и найдем b из уравнения прямой: b = -kx0 + y0, где х0, у0- координаты точки, принадлежащие этой прямой.
Рассмотрим 3 различные случая взаимной ориентации отрезков: на одной прямой, на параллельных прямых, на пересекающихся прямых:

1.	Проверяем, лежат ли отрезки на одной прямой. Если k1=k2 и b1=b2, то отрезки лежат на одной прямой. Следовательно отрезки могут иметь одну или несколько общих точек , либо не иметь их совсем. Отрезки будут пересекаться, когда конец либо начало одного из отрезков(в зависимости от расположения) лежит в промежутке координат конца и начала второго отрезка. Будем сравнивать по Y координатам. Для того, чтобы задать это условие, необходимо найти большую и меньшую координату для каждого отрезка и уже потом создать условие.
2.	Проверяем, параллельны ли отрезки. Если k1=k2 , а b1 и b2 не равны между собой, тогда прямые параллельны и отрезки не имеют общих точек.
3.	Рассмотрим случай пересекающихся прямых. Коэффициенты k1 и k2 не равны, следовательно прямые пересекаются. В этом случае отрезки могут иметь общую точки, либо не иметь их совсем. Найдем точку пересечения двух прямых:
y1=k1x+b1, y2=k2x+b2
y1=y2
k1x+b1=k2x+b2
x = (b2-b1)/(k1-k2)
Проверяем, принадлежит ли найденная точка каждому из наших отрезков(задаем условие, аналогичное условию в п.1, только в этот раз сравниваем по X координате). Если точка принадлежит обоим отрезкам, то отрезки пересекаются в этой точке.

####Примечания:

1.	Вводными данными являются только числа.
2.	Числа могут быть как положительными, так и отрицательными.
3.	Дробные числа вводятся в виде десятичной дроби.
4.	Не допускается ввод иных символов.
