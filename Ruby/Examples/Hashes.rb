employees = Hash.new

scores = { "john" => 100, "mary" => 200 }

puts scores["john"] # 100

scores["tom"] = 300 # adds the key/value pair if it doesn't exist

puts scores 