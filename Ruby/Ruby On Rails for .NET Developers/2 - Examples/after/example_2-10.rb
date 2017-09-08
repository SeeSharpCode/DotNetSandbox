
def method1
	puts "Inside Method1"
end

puts "Outside of a method"

def is_even?(value)
	value % 2 == 0
end

def add_numbers!(x,y)
	x + y
end

method1
is_even? 3
add_numbers! 2, 3
