class Employee
  # getter
  def id
    @id
  end

  # setter using = convention
  def id=(value)
    @id = value
  end

  attr_accessor :first_name # shorthand for read/write attribute
  attr_reader :last_name # shorthand for readonly attribute
  attr_writer :age # shorthand for writeonly attribute

  def method1
    # 2 different ways to access instance attributes
    puts @first_name
    puts self.last_name
  end
end

e = Employee.new
e.id = 10
e.first_name = "Bob"

puts e.id
puts e.first_name

e.method1
