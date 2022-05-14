pub fn square_of_sum(n: u32) -> u32 {
    let mut ss: u32 = 0;
    for i in 1..n+1 {
        ss += i;
    }
    return ss*ss;
}

pub fn sum_of_squares(n: u32) -> u32 {
    let mut ss: u32 = 0;
    for i in 1..n+1 {
        ss += i*i;
    }
    return ss;
}

pub fn difference(n: u32) -> u32 {
    return square_of_sum(n) - sum_of_squares(n);
}
