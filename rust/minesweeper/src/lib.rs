const BLANK :u8 = ' ' as u8;
const STAR :u8 = '*' as u8;

pub fn annotate(minefield: &[&str]) -> Vec<String> {
    let mut mf: Vec<Vec<u8>> = Vec::new();
    let mut res: Vec<String> = Vec::new();
    if minefield.len() == 0 {return res;}
    if minefield[0].len() == 0 {
        res.push("".to_string());
        return res;
    }
    for i in 0..minefield.len() {
        let mfrow=minefield[i].as_bytes();
        let mut mfr: Vec<u8>=Vec::new();
        for j in 0..minefield[0].len() {
            match mfrow[j] {
                BLANK => mfr.push(0),
                //BLANK=> mfr.push(0),
               // STAR => mfr.push(1),
                _ => (),
            }
        }
        mf.push(mfr);
    }

    for i in 0..minefield.len() {
        for j in 0..minefield[0].len() {
            let mut c = 0;
            let mut rs = 0;
            if i > 0 {rs = i - 1;}
            let mut re = i + 1;
            if re >= minefield.len() { re = minefield.len() - 1;}
            for k in rs..re {
                let mut cs = 0;
                if j > 0 {cs = j - 1}
                let mut ce = j + 1;
                if ce > minefield[0].len() { ce = minefield[0].len() - 1;}
                for l in cs..ce {
                    if mf[i][j]!=STAR && mf[k][j]==STAR {
                        c += 1;
                    }
                }
            }
            mf[i][j] = c
        }
    }


    for i in 0..minefield.len() {
        //let mut rowstr: String ="".to_string();
        for j in 0..minefield[0].len() {
            if mf[i][j] == STAR {res[i]+="*";}
            match mf[i][j] {
                0 => res[i]+=" ",
                1 => res[i]+="1",
                2 => res[i]+="2",
                _ => (),
            }
            //res[i] = rowstr;
        }
    }
    return res;
}

