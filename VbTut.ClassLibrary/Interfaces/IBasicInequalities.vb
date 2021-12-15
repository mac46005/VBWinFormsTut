Public Interface IBasicInequalities(Of T)
    Function GreaterThan(x As T, y As T) As T
    Function GreaterThanEqualToo(x As T, y As T) As T
    Function LessThan(x As T, y As T) As T
    Function LessThanEqualToo(x As T, y As T) As T
    Function EqualToo(x As T, y As T) As T
    Function NotEqualToo(x As T, y As T) As T

End Interface
