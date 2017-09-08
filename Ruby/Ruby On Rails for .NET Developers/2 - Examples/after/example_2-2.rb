class Item

$path = "/bin/" #Available anywhere

@@text = "Hello" #Single instance shared by all class instances

def set_id(value)
  @id = value #Available only to this class
end

def set_text(new_text)
  @@text = new_text
end

def print_all
  localVar = 10 #Only available to this method

  puts localVar
  puts @id
  puts @@text
end

end

i1 = Item.new
i2 = Item.new

i1.set_id(5)
i1.print_all

i2.set_id(6)
i2.set_text("Goodbye")

i2.print_all
i1.print_all

puts $path