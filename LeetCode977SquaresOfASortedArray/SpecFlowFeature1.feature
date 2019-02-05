Feature:  Squares Of a Sorted Array
	In order to 正確計算平方值並排序
	As 身為一個使用者
	I want to 我希望能輸入陣列資料後輸出平方值並排序
@mytag
Scenario: Squares Of a Sorted Array Example 1
	Given I Enter Array into the SortedSquares
	| A  |
	| -4 |
	| -1 |
	| 0  |
	| 3  |
	| 10 |
	When I exec SortedSquares
	Then the result should be 
	| Result |
	| 0      |
	| 1      |
	| 9      |
	| 16     |
	| 100    |

Scenario: Squares Of a Sorted Array Example 2
	Given I Enter Array into the SortedSquares
	| A  |
	| -7 |
	| -3 |
	| 2  |
	| 3  |
	| 11 |
	When I exec SortedSquares
	Then the result should be 
	| Result |
	| 4      |
	| 9      |
	| 9      |
	| 49     |
	| 121    |