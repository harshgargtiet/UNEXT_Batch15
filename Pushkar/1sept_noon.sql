CREATE OR REPLACE FUNCTION update_category_trigger_function()
RETURNS TRIGGER AS $$
BEGIN
    IF NEW.price > 500 THEN
        NEW.category = 'Premium';
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER update_category_trigger
BEFORE UPDATE ON products
FOR EACH ROW
EXECUTE FUNCTION update_category_trigger_function();