# 1 МНК
Используемые библиотеки: NumPy, Matplotlib
## Задание:
Провести анализ аппроксимации полиномами в следующих методах:
* Полиномиальная регрессия
* Полиномиальная регрессия с зашумлённым данными
* Метод наименьших квадратов (МНК)
## Вывод:
1. Полиномиальная регрессия: хорошо аппроксимирует при небольшом количестве точек и при отсутствии шумов, аппроксимация становится 
хуже даже при низких значениях шума. 
2. Метод наименьших квадратов: аппроксимирует достаточно точно, позволяет строить полиномы с небольшими 
значениями степеней и с большим количеством точек, аппроксимация не становится хуже при добавлении шума.
# 2 PCA, kNN
Используемые библиотеки: NumPy, Matplotlib, Pandas, sklearn
## Задание:
Реализовать методы работы с данными: 
* PCA (метод главных компонент) 
* kNN (метод k-ближайших соседей)
## Вывод:
1. Для заданного датасета (база данных digits) преобразованы данные с помощью метода PCA, построен график собственных значений и 
график отношения кумулятивной суммы собственных значений к их полной сумме.
3. Для заданного датасета (pca_knn.csv) уменьшена размерность данных с помощью метода PCA, применён метод kNN
и определена наилучшая точность $= 96.467$, которая достигаетя при количестве соседей $k=1$ и $k=2$ и количестве компонент $= 29$ и $31$.
# 3 Pandas
Используемые библиотеки: Pandas, Seaborn, datetime
## Вывод:
Получены и улучшены навыки в работе с библиотекой Pandas и визуализацией данных.
# 4 Анализ данных
Используемые библиотеки: NumPy, Matplotlib, Pandas, Seaborn, sklearn
## Задание:
Изучить основные библиотеки для анализа данных, а также линейные модели и методы их обучения.
## Вывод:
1. Применены библиотеки NumPy и Pandas для осуществления желаемых преобразований
2. Подготавлены данные для обучения линейных моделей
3. Обучены линейная, Lasso и Ridge-регрессии при помощи модуля scikit-learn
4. Реализовываны обычный и стохастический градиентные спуски
5. Обучена линейная регрессию для произвольного функционала качества.
# 5 QP, SVM
Используемые библиотеки: NumPy, Matplotlib, cvxopt, sklearn
## Задание:
1. Провести знакомство с QP-солвером (QP – квадратичное программирование)
2. Свести задачу обучения линейного SVM (метод опорных векторов) к QP, реализовать процедуру обучения линейного SVM при помощи QP-солвера
3. Протестировать линейный SVM на трёх сгенерированных случайных двумерных выборках (линейно разделимая; хорошо разделимая, но не линейно;
плохо разделимые) для бинарной классификации и построить классификаторы с различным значением гиперпараметра $C$, который задает баланс 
между шириной разделяющей полосы и ошибками, допускаемыми классификатором
4. Используя явное преобразование признаков методом опорных векторов обучить квадратичную разделяющую поверхность
5. С помощью QP-солвера реализовать процедуру обучения ядрового SVM
6. На случайных двумерных выборках протестировать ядровой SVM, используя линейную, полиномиальную и Гауссовскую-RBF ядровые функции.
## Вывод:
1. Линейный SVM:
* Число опорных векторов уменьшается при увеличении значения параметра $С$. Уменьшается ширина полосы.
2. Ядровой SVM:
* SVM с полиномиальным ядром: при более высоких степенях полинома лучше строятся границы классов, но также большая степень ведёт к переобучению; 
с увеличением $С$ уменьшаетя ширина полосы, большое $С$ ведёт к переобучению.
* SVM с RBF-ядром: при малом $С$ грубая модель; При малом $\gamma$ – переобучение модели, при большом $\gamma$ – грубая модель.
# 6 Методы оптимизации в ML
Используемые библиотеки: NumPy, Matplotlib, SciPy, Oracles, Optimization, presubmit_tests, sklearn, plot_trajectory_2d
## Задание:
1. Реализовать метод градиентного спуска и процедуа линейного поиска
2. Получить формулы для градиента и гессиана функции логистической регрессии
3. Реализовать оракул логистической регрессии
4. Реализовать подсчет разностных производных
5. Реализовать метод Ньютона
6. Проведести экспеперименты:
* Траектория градиентного спуска на квадратичной функции
* Зависимость числа итераций градиентного спуска от числа обусловленности и размерности пространства
* Сравнение методов градиентного спуска и Ньютона на реальной задаче логистической регрессии
## Вывод:
### Эксперимент 1:
* Чем больше число обуловленности, тем большее количество итераций требуется всем методам для спуска (увеличивается количество зигзагов).
* Выбор начальной точки влияет только на количество итераций: чем ближе точка к минимуму, тем меньше итераций.
* Стратегия выбора шага влияет на скороть спуска, на количество итераций: при константной стратегии требуется больше всего итераций, а при 
оптимизационном выборе (Вульф) – меньше всего.
### Эксперимент 2:
* C увеличением числа обусловленности уменьшается число итераций для метода Constant
* C увеличением числа обусловленности растет число итераций для методов Armijo и Wolfe
* Размерность пространства не существенно влияет на количество итераций
### Эксперимент 3:
* w8a: оба метода быстрее сходятся для небольшой заданной точности (в начале) и медленнее для большой (в конце). Метод Ньютона сходится быстрее.
* gisette: скачкообразный график градиентного спуска для зависимости относительного квадрата нормы градиента против реального времени работы. 
Метод градиентного спуска сходится быстрее.
# 7 Решающие деревья
Используемые библиотеки: NumPy, Matplotlib, Pandas, Seaborn, sklearn, warnings
## Задание:
Научитья применять деревья из sklearn для задачи классификации. Посмотреть какие разделяющие поверхности деревья строят 
для различных датасетов и проанализировать их зависимость от различных гиперпараметров.
## Вывод:
1. При обучении мы получили 100% точность на всех выборках. При тестировании точность уменьшилась, так как решающие деревья переобучились из-за того, 
что модель пытается описать не выборку в целом, а каждый объект отдельно: например, во время обучения появились оранжевые области там, где были единичные 
оранжевые объекты, а затем эти области перенеслись на тесты. При увеличении максимальной глубины и при уменьшении минимального количества объектов растёт 
точность на обучающей выборке.
2. Реализовать своё решающее дерево и сравнить его со стандартной имплиментацией из sklearn. 
Протестировать деревья на более сложных датасетах и сравнить различные подходы к кодированию категориальных признаков.
