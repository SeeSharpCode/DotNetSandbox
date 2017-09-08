puts "test".object_id == "test".object_id
puts :"test".object_id == :"test".object_id
puts :"test".object_id == :test.object_id

#Output
#false
#true
#true