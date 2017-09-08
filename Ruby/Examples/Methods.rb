def method1
  puts "Inside Method1"
end

puts "Outside of a Method"

def is_even(value)
  value % 2 == 0
end

def add_numbers(x,y)
    x + y
end

method1 # parentheses not required
# puts is_even 3 # parentheses not required
puts is_even(3)
puts add_numbers(2,3)

def is_odd?(value) # ? is a convention for methods returning bool
  value % 2 != 0
end

puts is_odd? 3 # ? is a convention for methods returning bool

# methods ending with ! should be used with caution
# they are often mutators which alter the internal state of the object
def method_should_be_used_with_caution!(x,y)
  puts x + y
end

method_should_be_used_with_caution! 2,3

s1 = "Hello"
puts s1

result = s1.gsub("e", "a") # returns new string
puts result

s1.gsub!("e", "a") # changes value of s1
puts s1
