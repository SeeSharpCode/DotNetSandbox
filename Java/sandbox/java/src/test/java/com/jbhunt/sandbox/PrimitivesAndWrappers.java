package com.jbhunt.sandbox;

import org.junit.Assert;
import org.junit.Test;

public class PrimitivesAndWrappers {
    @Test
    public void primitiveTypeConversion() {
        // "widening" conversions are automatic, i.e. going from a smaller (int) type to a wider (long) type
        int i = 1;
        long l = i;
        Assert.assertEquals(1, l);
    }

    @Test
    public void primitiveWrappers() {
        // classes provide convenience, but primitives provide efficiency
        // wrapper classes are immutable

        // conversion handled for you
        Integer foo = 3;
        int bar = foo;
        Integer baz = bar;

        // explicit conversion
        int a = 3;
        Integer b = Integer.valueOf(a); // boxing
        int c = b.intValue(); // unboxing

        String s = "1.2";
        double d = Double.parseDouble(s);
        double e = Double.valueOf(s);
    }
}
