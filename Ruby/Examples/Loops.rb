colors = ['green', 'red', 'blue']

for color in colors
  puts color
end

x = 0

while x > 10
  x += 1
end

until x == 10
  x += 1
end

@y = 0

def do_work
  @y += 1
  puts @y
end

do_work until @y == 10

colors.each do |c|
  puts c
end

5.times do |i|
  puts i
end

1.upto 3 do |i|
  puts i
end

3.downto 1 do |i|
  puts i
end
