# 1 Messenger
Используемые библиотеки: clientui, requests, time, datetime, PyQt6, json, flask
## Задание:
1. Создать простейший мессенджер, настроить протокол TCP для мессенджера, написать интерфейс мессенджера
2. Провести коммуникацию между одногруппниками
3. На странице status отображащить текущее время, информацию о количестве пользователей мессенджера и количестве сообщений, которое было передано
4. Добавить дополнительную обработку поступающих сообщений (чат-бот) в мессенджер
5. Добавить возможность делать анонимные сообщения
# 2 Вычислительная сложность
## Задание:
Реализовать алгоритм TwoSum (задача LeetCode) с различной вычислительной сложностью ($O(N)$, $O(N^2)$, $O(N \ln N)$)
# 3 LU-разложение и LUP-разложение
Используемые библиотеки: NumPy, SciPy
## Задание:
1. Реализовать методы LU и LUP разложений, с помощью них решить СЛАУ
2. Сравнить методы
## Вывод:
1. LU-разложение не подходит для решения СЛАУ, в которых приведение к ступенчатому виду матрицы коэффициентов предполагает перестановку строк, 
так как возможно появление 0 на главной диагонали, а значит разложение матрицы коэффициаентов на нижнюю треугольную матрицу L и верхнюю
треугольную матрицу U невозможно. Однако LUP-разложение подходит для решения таких СЛАУ.
2. Решение СЛАУ с помошью LU-разложения занимет меньше времени, чем решение СЛАУ с помощью LUP-разложения \
Таким образом, эффективнее использовать LUP-разложение, так как оно более универсально. Но стоит отметить, что решение с помощью LU-разложения вы найдёте быстрее.
# 4 NumPy
Используемые библиотеки: NumPy
## Задание:
1. Углубиться в изучение библиотеки NumPy
2. Численно посчитать определённый интеграл 3-мя методами:
* Прямоугольников 
* Трапеций 
* Симпсона 
## Вывод:
Метод Симсона требует меньше разбиений, чем метод трапеций и прямоугольников. \
Метод трапеций требует меньше разбиений, чем метод прямоугольников. \
Также, неутрудно заметить, что метод Симпсона более точный, ближе к аналитическому решению
# 5
Часть 1: обработка строк и функция map \
Часть 2: библиотека Matplotlib
Используемые библиотеки: NumPy, Matplotlib, SciPy, mpl_toolkits.mplot3d.axes3d
## Задание:
1. Используя срезы, дополнительные списки, методы строк и функцию map решить представленные задачи с ограничениев в заданное количетво строк в программе
2. Изучить библиотеку Matplotlib:
* Создать график
* Создать semilogy график
* Создать графики специальных функций из библиотеки SciPy 
* Добавить сетку и тики (обозначения тиков должны содержать греческую букву $\pi$)
* Создать цветовой график
* Создать 3D-график