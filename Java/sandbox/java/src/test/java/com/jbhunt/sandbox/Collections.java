package com.jbhunt.sandbox;

import org.junit.Assert;
import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Collections {
    @Test
    public void collections() {
        List<String> list = new ArrayList<>();
        list.add("Steve");
        Assert.assertEquals(1, list.size());
        list.remove("Steve");
        Assert.assertEquals(0, list.size());
    }

    @Test
    public void collectionsAndArrays() {
        List<String> list = new ArrayList<>();
        list.add("foo");
        list.add("bar");
        String[] array = list.toArray(new String[0]);
        Assert.assertEquals(2, array.length);
        List<String> convertedList = Arrays.asList(array);
        Assert.assertEquals(2, convertedList.size());
    }

    @Test
    public void lambdas() {
        List<String> list = new ArrayList<>();
        list.add("foo1");
        list.add("foo2");
        list.add("bar");

        list.forEach(System.out::println);
        list.removeIf(s -> s.equalsIgnoreCase("foo1"));
        Assert.assertEquals(2, list.size());
    }
}
