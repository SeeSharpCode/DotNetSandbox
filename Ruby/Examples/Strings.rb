s1 = "Hello\nWorld"
s2 = 'Hello\nWorld'
s3 = '.NET'
s4 = "Ruby on Rails for #{s3} Developers"
s5 = "Ruby on Rails for " + s3 + " Developers"

puts s1
puts s2
puts s3
puts s4
puts s5

#Expected Output
#Hello
#World
#Hello\nWorld
#.NET
#Ruby on Rails for .NET Devlopers
#Ruby on Rails for .NET Developers

puts 'Hello'.length
puts 'Hello'[1]
puts 'Hello'.split('e')
puts 'Hello Ruby'.gsub('Hello', 'Goodbye')
puts 'Hello Ruby'.replace('Goodbye')
puts 'HELLO'.downcase
puts 'HELLO'.upcase
puts 'hElLo'.capitalize

#Output
#5
#e
#H - first half of split
#llo - second half of split
#Goodbye Ruby
#Goodbye
#hello
#HELLO
#Hello
