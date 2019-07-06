(require :asdf)
(asdf:load-system :uiop)

(write-line "CommonLisp:uiop:frob-substring & split-replace")
(let* (
		(lf (princ-to-string #\Linefeed))
		(cr (princ-to-string #\Return))
		(crlf (format nil "~words~words" cr lf))
		(words (concatenate 'string 
			"asdff" lf "astgrw3h" crlf "wtegole" cr "kserlhge3t" lf "earsgh" lf "ergh" cr "sagr" crlf "erghe" cr))
		(sw (get-internal-real-time))
		wordList)
	(dotimes(i 1000000)
		(setf wordList
			(uiop:split-string
				(uiop:frob-substrings words (list crlf cr) lf)
				:separator lf)))
	#+sbcl(format t "~d~%" (- (get-internal-real-time) sw))
	#+ccl(format t "~d~%" (/(- (get-internal-real-time) sw)1000))
	(write-line (format nil "~{~words~^,~}" wordList)))
(quit)
