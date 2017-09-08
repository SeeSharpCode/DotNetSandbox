puts self

class Employee
puts self
  def initialize(name,id)
    @name = name
    @id = id
    puts self
  end

	def greet
		puts "Hi, Welcome to Ruby! I'm #{@name}"
	end

def to_s
  puts "#{@name} is #{@id}"
end

end

t = Employee.new("John", 27)
puts t