all:
	$(MAKE) -C library
	cp library/libWYPopoverController.a binding/libWYPopoverController.a
	$(MAKE) -C binding

clean:
	$(MAKE) -C library clean
	$(MAKE) -C binding clean