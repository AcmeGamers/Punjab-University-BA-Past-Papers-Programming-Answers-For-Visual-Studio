' ====
' Q2 A
' ====
Public Module Program
	Public Sub Main(args() As string)

  ' 3.9 / Minute
  ' loop to show calories burned after 10,15,20,30 mins later
  
  Dim minutes() as Integer = { 10, 15, 20, 30 }
  Dim caloriesPerMinute as Integer = 3.9
  
  for number as Integer = 0 to minutes.length - 1
    Console.WriteLine("{0} mins passed, burned calories: {1}", minutes(number), caloriesPerMinute * minutes(number))
  Next

	End Sub
End Module

' ====
' Q2 B
' ====
Public Module Program
	Public Sub Main(args() As string)
  
    ' Rs. 2500/year
    ' 4% increase
    ' from year 1 to 6
    
    Dim subscription as Integer = 2500
    Dim increase as Integer = 4
    
    for i as Integer = 1 to 6
      Console.WriteLine("Year {0}, Fee: {1}", i, (subscription + (subscription * (i + increase) / 100)))
    Next
  
	End Sub
End Module

' ===========
' Q2 C (Stub)
' ===========

' Adding new value to array
Public Module Program
	Public Sub Main(args() As string)
  
  Dim numbers() as Integer = {}
  
  Redim Preserve numbers(numbers.length)
  numbers(numbers.length - 1) = 120
  
  Redim Preserve numbers(numbers.length)
  numbers(numbers.length - 1) = 10
  
  Redim Preserve numbers(numbers.length)
  numbers(numbers.length - 1) = 1120
  
  Redim Preserve numbers(numbers.length)
  numbers(numbers.length - 1) = 12510
  
  Redim Preserve numbers(numbers.length)
  numbers(numbers.length - 1) = 121
  
  Redim Preserve numbers(numbers.length)
  numbers(numbers.length - 1) = 1
  
  Redim Preserve numbers(numbers.length)
  numbers(numbers.length - 1) = 110
  
  Redim Preserve numbers(numbers.length)
  numbers(numbers.length - 1) = 12
  
  Redim Preserve numbers(numbers.length)
  numbers(numbers.length - 1) = 13
  
  Redim Preserve numbers(numbers.length)
  numbers(numbers.length - 1) = 15
  
  Console.Write(numbers.length)
  
	End Sub
End Module

' Adding new value to array printing them out
Public Module Program
	Public Sub Main(args() As string)
  
  Dim numbers() as Integer = {}
  
  for i as Integer = 0 to 9
    Redim Preserve numbers(numbers.length)
    numbers(numbers.length - 1) = Math.Ceiling(Rnd() * 10)
  next
  
  For Each number As Integer In numbers
    Console.WriteLine(number)
  Next
  
	End Sub
End Module


' ====
' Q2 C
' ====

Public Module Program
	Public Sub Main(args() As string)
  
    Dim numbers() as Integer = {}
    
    for i as Integer = 0 to 9
      Redim Preserve numbers(numbers.length)
      numbers(numbers.length - 1) = Math.ceiling(Rnd() * 10)
    next
    
    ' Sorting Arrays
    Array.Sort(numbers)
    
    for j as Integer = 0 to 9
      Console.WriteLine(numbers(j))
      
    next
  
	End Sub
End Module

' ====
' Q2 D
' ====
