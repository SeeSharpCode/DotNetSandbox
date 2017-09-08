puts self

class Employee
  puts self
  def initialize(name) # equates to .NET constructor
    @name = name
  end

  def greet
    puts self
    puts "Hi, my name is #{@name}"
  end

  def self.this_is_static
    puts "This is static"
  end

  def to_s
    puts "#{@name} is the name of this person"
  end
end

# employee = Employee.new
employee = Employee.new('Tyler')
employee.greet
puts Employee.this_is_static
puts employee.to_s
