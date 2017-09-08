class Person
  def speak
    puts "Hi"
  end
end

class Dog
  def speak
    puts "Woof!"
  end
end

class Tree
  def grow
    puts "I'm growing"
  end
end

p = Person.new
d = Dog.new
t = Tree.new

def make_it_speak(person)
  person.speak
end

make_it_speak(p)
make_it_speak(d)
make_it_speak(t)

