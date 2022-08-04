' ====
' Q1 B
' ====
Public Module Program
	Public Sub Main(args() As string)
  ' find the middle value
  Dim a as Integer = 20
  Dim b as Integer = 125
  Dim c as Integer = 50
  
  if (a > b) And (a < c) Then
    Console.WriteLine("A is middle")
  else if (b > a) And (b < c) Then
    Console.WriteLine("B is middle")
  else 
    Console.WriteLine("C is middle")
  End if
  
	End Sub
End Module

' ====
' Q1 C
' ====
Public Module Program
	Public Sub Main(args() As string)
  ' area of rectangle == length * width
  ' asks length and width of two rectangle
  ' which one is betta
  Dim r_length_1 as Integer = 12
  Dim r_width_1 as Integer = 11
  
  Dim r_length_2 as Integer = 1
  Dim r_width_2 as Integer = 12
  
  Dim r_1 as Integer = r_length_1 * r_width_1
  Dim r_2 as Integer = r_length_2 * r_width_2
  
  if (r_1 < r_2) Then
    Console.WriteLine("Rectange 2 is betta")
  else
    Console.WriteLine("Rectange 1 is betta")
    
  End if
  
	End Sub
End Module

' ====
' Q1 D
' ====
Public Module Program
	Public Sub Main(args() As string)

    ' takes a positive number
    ' must display sum of 1 to n
    
    Dim supposeNumber as Integer = 10
    Dim result as Integer = 0
    
    for number as Integer = 1 to supposeNumber
      result = number + result
      Console.WriteLine("Number is: {0}", result)
    Next

	End Sub
End Module

' ====
' Q1 E
' ====
Public Module Program
	Public Sub Main(args() As string)

    ' takes 10 numbers from user
    ' gets the maximum value of all
    ' push data to string
    
    Dim highest as Integer = 0
    Dim data() as Integer = {0,131,4,1,41,41,23,12,31,23,13,12,31}
    
    for number as Integer = 0 to 9
      
      Console.WriteLine(data(number))
      
      if highest < data(number)
        highest = data(number)
      End if
      
    Next
    
    Console.WriteLine("Largest value is = {0}", highest)  

	End Sub
End Module

' ====
' Q1 F
' ====
Public Module Program
	Public Sub Main(args() As string)

  ' takes two inputs from user
  ' is a square of the number 
  ' 2 and 5 are entered by user
  ' result: (2, 4) (3, 9) (4, 16) (5, 20)
  
  Dim value1 as Integer = 1
  Dim value2 as Integer = 5
  
  while value1 <= value2
    Console.Write("({0}, {1}) ", value1, (value1 * value1))
    value1 += 1
  End while
    

	End Sub
End Module
